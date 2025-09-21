using SpecificationPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Data
{
    public class Shop
    {
        public IEnumerable<Product> GetProducts() {  return products; }
        public IEnumerable<Product> products = new List<Product>()
        {
            new Product(1, "Samsung S24", 124000, "Samsung", "Mobile Phone"),
            new Product(2, "iPhone 15 Pro", 149999, "Apple", "Mobile Phone"),
            new Product(3, "OnePlus 12", 89999, "OnePlus", "Mobile Phone"),
            new Product(4, "Google Pixel 8", 99999, "Google", "Mobile Phone"),
            new Product(5, "Xiaomi 14", 74999, "Xiaomi", "Mobile Phone"),
            new Product(6, "Sony WH-1000XM5", 34999, "Sony", "Headphones"),
            new Product(7, "Bose QuietComfort 45", 32999, "Bose", "Headphones"),
            new Product(8, "Apple AirPods Pro", 24999, "Apple", "Earbuds"),
            new Product(9, "Samsung Galaxy Buds2 Pro", 19999, "Samsung", "Earbuds"),
            new Product(10, "JBL Flip 6", 12999, "JBL", "Bluetooth Speaker"),
            new Product(11, "Dell XPS 13", 139999, "Dell", "Laptop"),
            new Product(12, "MacBook Air M2", 119999, "Apple", "Laptop"),
            new Product(13, "HP Spectre x360", 129999, "HP", "Laptop"),
            new Product(14, "Lenovo ThinkPad X1", 149999, "Lenovo", "Laptop"),
            new Product(15, "Asus ROG Zephyrus", 179999, "Asus", "Gaming Laptop"),
            new Product(16, "LG OLED C3 55\"", 159999, "LG", "TV"),
            new Product(17, "Samsung QN90C 65\"", 199999, "Samsung", "TV"),
            new Product(18, "Sony Bravia XR A80K", 179999, "Sony", "TV"),
            new Product(19, "TCL 6-Series 55\"", 69999, "TCL", "TV"),
            new Product(20, "Hisense U8H 65\"", 89999, "Hisense", "TV"),
            new Product(21, "Canon EOS R5", 389999, "Canon", "Camera"),
            new Product(22, "Sony Alpha A7 IV", 329999, "Sony", "Camera"),
            new Product(23, "Nikon Z7 II", 349999, "Nikon", "Camera"),
            new Product(24, "Fujifilm X-T5", 219999, "Fujifilm", "Camera"),
            new Product(25, "GoPro HERO12", 44999, "GoPro", "Action Camera"),
            new Product(26, "Apple Watch Ultra 2", 89999, "Apple", "Smartwatch"),
            new Product(27, "Samsung Galaxy Watch 6", 39999, "Samsung", "Smartwatch"),
            new Product(28, "Fitbit Charge 6", 19999, "Fitbit", "Fitness Tracker"),
            new Product(29, "Garmin Fenix 7", 79999, "Garmin", "Smartwatch"),
            new Product(30, "Amazfit GTR 4", 24999, "Amazfit", "Smartwatch"),
            new Product(31, "Kindle Paperwhite", 16999, "Amazon", "E-Reader"),
            new Product(32, "iPad Pro 12.9\"", 129999, "Apple", "Tablet"),
            new Product(33, "Samsung Galaxy Tab S9", 89999, "Samsung", "Tablet"),
            new Product(34, "Microsoft Surface Pro 9", 119999, "Microsoft", "Tablet"),
            new Product(35, "Lenovo Tab P11 Pro", 49999, "Lenovo", "Tablet"),
            new Product(36, "PlayStation 5", 54999, "Sony", "Gaming Console"),
            new Product(37, "Xbox Series X", 54999, "Microsoft", "Gaming Console"),
            new Product(38, "Nintendo Switch OLED", 34999, "Nintendo", "Gaming Console"),
            new Product(39, "Steam Deck", 49999, "Valve", "Handheld Console"),
            new Product(40, "Razer Kishi V2", 9999, "Razer", "Controller"),
            new Product(41, "Logitech MX Master 3S", 12999, "Logitech", "Mouse"),
            new Product(42, "Apple Magic Keyboard", 14999, "Apple", "Keyboard"),
            new Product(43, "Corsair K100 RGB", 24999, "Corsair", "Keyboard"),
            new Product(44, "WD My Passport 2TB", 8999, "Western Digital", "External HDD"),
            new Product(45, "Samsung T7 Shield 1TB", 12999, "Samsung", "SSD"),
            new Product(46, "Anker PowerCore 26K", 7999, "Anker", "Power Bank"),
            new Product(47, "Belkin BoostCharge 30W", 3999, "Belkin", "Charger"),
            new Product(48, "UGREEN USB-C Hub", 4999, "UGREEN", "Adapter"),
            new Product(49, "Ring Video Doorbell 4", 24999, "Ring", "Smart Home"),
            new Product(50, "Nest Learning Thermostat", 19999, "Google", "Smart Home")
        };
    }
}
