import pandas as pd
import sqlite3
import os

# 1. Excel dosyasını oku
excel_dosya = 'tonerlistesi2.xlsx'  # Excel dosyanızın adı
df = pd.read_excel(excel_dosya)  # Excel'deki verileri oku (tek sekme varsayımı)

# 2. SQLite veritabanına bağlan
veritabani = 'stok.db'
baglanti = sqlite3.connect(veritabani)
imlec = baglanti.cursor()

# 3. Tabloyu oluştur (eğer yoksa) - Mevcut şemaya uygun
imlec.execute("""
CREATE TABLE IF NOT EXISTS urun_tablo (
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    ÜRÜN_ADI TEXT,
    BİRİM TEXT,
    KATEGORİ TEXT,
    MİKTAR INTEGER
)
""")

# 4. Boş ID'yi bulan fonksiyon
def get_next_available_id(table_name):
    imlec.execute(f"SELECT ID FROM {table_name} ORDER BY ID")
    ids = [row[0] for row in imlec.fetchall()]
    expected_id = 1
    for current_id in ids:
        if current_id != expected_id:
            return expected_id
        expected_id += 1
    return expected_id

# 5. Excel sütunlarını veritabanı şemasına eşle
column_mapping = {
    'ÜRÜN ADI': 'ÜRÜN_ADI',
    'BİRİM': 'BİRİM',
    'KATEGORİ': 'KATEGORİ',
    'MİKTAR': 'MİKTAR'
}
df = df.rename(columns=column_mapping)

# 6. Veriyi ekle
for _, row in df.iterrows():
    try:
        # Doğrulamalar
        if pd.isna(row['ÜRÜN_ADI']) or pd.isna(row['BİRİM']) or pd.isna(row['KATEGORİ']):
            print(f"Satır atlandı: ÜRÜN_ADI, BİRİM veya KATEGORİ boş. Satır: {row.to_dict()}")
            continue
        if pd.isna(row['MİKTAR']) or not isinstance(row['MİKTAR'], (int, float)):
            print(f"Satır atlandı: MİKTAR geçerli bir sayı değil. Satır: {row.to_dict()}")
            continue

        yeni_id = get_next_available_id('urun_tablo')
        imlec.execute("""
        INSERT INTO urun_tablo (ID, ÜRÜN_ADI, BİRİM, KATEGORİ, MİKTAR)
        VALUES (?, ?, ?, ?, ?)
        """, (yeni_id, str(row['ÜRÜN_ADI']), str(row['BİRİM']), str(row['KATEGORİ']), int(row['MİKTAR'])))
    except Exception as e:
        print(f"Hata oluştu (satır: {row.to_dict()}): {e}")
        continue

# 7. Bağlantıyı kaydet ve kapat
baglanti.commit()
baglanti.close()

print(f"'{excel_dosya}' dosyasındaki veriler '{veritabani}' veritabanındaki urun_tablo tablosuna eklendi. ID'ler sıralı şekilde atandı.")