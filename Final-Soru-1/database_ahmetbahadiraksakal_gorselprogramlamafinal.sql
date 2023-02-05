-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 19 Oca 2023, 13:55:27
-- Sunucu sürümü: 10.4.24-MariaDB
-- PHP Sürümü: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `database_ahmetbahadiraksakal_gorselprogramlamafinal`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kisi`
--

CREATE TABLE `kisi` (
  `id_kisi` int(11) NOT NULL,
  `ad_kisi` varchar(95) COLLATE utf8_turkish_ci DEFAULT NULL,
  `soy_ad_kisi` varchar(95) COLLATE utf8_turkish_ci DEFAULT NULL,
  `tel_kisi` varchar(95) COLLATE utf8_turkish_ci DEFAULT NULL,
  `unvan_kisi` varchar(95) COLLATE utf8_turkish_ci DEFAULT NULL,
  `sinif_kisi` varchar(95) COLLATE utf8_turkish_ci DEFAULT NULL,
  `kurum_kisi` varchar(95) COLLATE utf8_turkish_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `kisi`
--

INSERT INTO `kisi` (`id_kisi`, `ad_kisi`, `soy_ad_kisi`, `tel_kisi`, `unvan_kisi`, `sinif_kisi`, `kurum_kisi`) VALUES
(3, 'Emre', 'durrmaz', '5045876349', 'Öğrenci', '4', NULL),
(4, 'Levent', 'Yılmaz', '0563552523', 'Çalışan', NULL, 'BTÜ'),
(5, 'yılmaz', 'doğan', '0546345535', 'Öğrenci', '12', NULL),
(7, 'Akif', 'Kahveci', '05342341253', 'Öğrenci', '6', NULL),
(8, 'Ali', 'Yıldırım', '0546234123', 'Öğrenci', '9', NULL),
(9, 'Durmuş', 'Erson', '05418951123', 'Çalışan', NULL, 'Belediye'),
(12, 'Bahadır', 'Aksakal', '05350456793', 'Çalışan', NULL, 'Güncel yazılım');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kisi`
--
ALTER TABLE `kisi`
  ADD PRIMARY KEY (`id_kisi`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kisi`
--
ALTER TABLE `kisi`
  MODIFY `id_kisi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
