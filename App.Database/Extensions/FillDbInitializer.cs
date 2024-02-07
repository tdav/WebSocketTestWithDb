using App.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace App.Database.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var g = Guid.Parse("1c095b27-d060-4ed1-9167-4c9745196e2e");
            var rg = Guid.Parse("1c095b27-d060-4ed1-9167-4c9745196e2e");
            var d1 = DateTime.Parse("2023-10-09");


            #region Region District
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 10, NameUz = "ТОШКЕНТ ШАҲРИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 11, NameUz = "ТОШКЕНТ ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 12, NameUz = "СИРДАРЁ ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 13, NameUz = "ЖИЗЗАХ ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 14, NameUz = "САМАРҚАНД ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 15, NameUz = "ФАРҒОНА ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 16, NameUz = "НАМАНГАН ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 17, NameUz = "АНДИЖОН ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 18, NameUz = "ҚАШҚАДАРЁ ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 19, NameUz = "СУРХОНДАРЁ ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 20, NameUz = "БУХОРО ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 21, NameUz = "НАВОИЙ ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 22, NameUz = "ХОРАЗМ ВИЛОЯТИ", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spRegion>().HasData(new spRegion() { Id = 23, NameUz = "ҚОРАҚАЛПОҒИСТОН РЕСПУБЛИКАСИ", Status = 1, CreateUser = g, CreateDate = d1 });


            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1812, NameUz = "КАСБИ ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1813, NameUz = "МУБОРАК ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1815, NameUz = "ҚАРШИ ШАҲРИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1816, NameUz = "ШАҲРИСАБЗ ШАҲРИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1901, NameUz = "ТЕРМИЗ ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1902, NameUz = "БОЙСУН ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1903, NameUz = "МУЗРАБОТ ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1904, NameUz = "САРИОСИЁ ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1905, NameUz = "ШАРҒУН ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1906, NameUz = "ШЎРЧИ ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1907, NameUz = "ОЛТИНСОЙ ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1908, NameUz = "ҚУМҚЎРҒОН ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1909, NameUz = "ЖАРҚЎРҒОН ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1910, NameUz = "ҚИЗИРИҚ ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1911, NameUz = "АНГОР ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1912, NameUz = "ШЕРОБОД ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1913, NameUz = "УЗУН ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1914, NameUz = "ДЕНОВ ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1409, NameUz = "ПАСТДАРҒОМ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2204, NameUz = "УРГАНЧ ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2205, NameUz = "ШОВОТ ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2206, NameUz = "ХОНҚА ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2207, NameUz = "БОҒОТ ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2208, NameUz = "ЯНГИБОЗОР ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2209, NameUz = "ҚЎШКЎПИР ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2210, NameUz = "ХИВА ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2211, NameUz = "УРГАНЧ ШАҲРИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2212, NameUz = "ХИВА ШАҲРИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2213, NameUz = "ПИТНАК ШАҲРИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2301, NameUz = "НУКУС ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2302, NameUz = "КУНГИРОТ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1805, NameUz = "ҚАМАШИ ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2303, NameUz = "МЎЙНОҚ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2305, NameUz = "ТЎРТКЎЛ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2306, NameUz = "ЭЛЛИКҚАЛЪА ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2307, NameUz = "КЕГЕЙЛИ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2308, NameUz = "АМУДАРЁ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2309, NameUz = "БЕРУНИЙ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2310, NameUz = "КАНЛИКОЛ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2311, NameUz = "ЧИМБОЙ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2312, NameUz = "ШУМАНАЙ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2313, NameUz = "ТАХТАКЎПИР ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2314, NameUz = "ХОЖЕЛИ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2315, NameUz = "БОЗАТАУ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2316, NameUz = "ҚОРАУЗОҚ ТУМАНИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2317, NameUz = "НУКУС ШАҲРИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2318, NameUz = "БЕРУНИЙ ШАҲРИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2319, NameUz = "КУНГИРОТ ШАҲРИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 739001141, NameUz = "ТУПРОҚҚАЛЪА ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 739001140, NameUz = "БЎСТОН ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2320, NameUz = "ТАКИЯТОШ ШАҲРИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2321, NameUz = "ТЎРТКЎЛ ШАҲРИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2322, NameUz = "ХОЖЕЛИ ШАҲРИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2323, NameUz = "ЧИМБОЙ ШАҲРИ", RegionId = 23, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1001, NameUz = "УЧТЕПА ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1202, NameUz = "ГУЛИСТОН ТУМАНИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1203, NameUz = "БОЁВУТ ТУМАНИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1204, NameUz = "МЕХНАТОБОД ТУМАНИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1205, NameUz = "ХОВОС ТУМАНИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1206, NameUz = "МИРЗАОБОД ТУМАНИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1207, NameUz = "ОҚОЛТИН ТУМАНИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1209, NameUz = "СИРДАРЁ ТУМАНИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1210, NameUz = "ГУЛИСТОН ШАҲРИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1211, NameUz = "СИРДАРЁ ШАҲРИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1212, NameUz = "ШИРИН ШАҲРИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1213, NameUz = "ЯНГИЕР ШАҲРИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1214, NameUz = "БАХТ ШАҲРИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1301, NameUz = "ЗАРБДОР ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1302, NameUz = "ДЎСТЛИК ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1304, NameUz = "ФОРИШ ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1305, NameUz = "ЖИЗЗАХ ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1306, NameUz = "ҒАЛЛАОРОЛ ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1307, NameUz = "БАХМАЛ ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1308, NameUz = "ПАХТАКОР ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1309, NameUz = "ЗАФАРОБОД ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1310, NameUz = "АРНАСОЙ ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1311, NameUz = "ЗОМИН ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1312, NameUz = "МИРЗАЧЎЛ ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1313, NameUz = "ЯНГИОБОД ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1519, NameUz = "ҚЎҚОН ШАҲРИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1520, NameUz = "МАРҒИЛОН ШАҲРИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1521, NameUz = "ФАРҒОНА ШАҲРИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1522, NameUz = "КИРГУЛИ ШАҲРИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1601, NameUz = "ДАВЛАТОБОД ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1602, NameUz = "МИНГБУЛОҚ ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1603, NameUz = "НАМАНГАН ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1604, NameUz = "НОРИН ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1605, NameUz = "УЙЧИ ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1606, NameUz = "УЧҚЎРҒОН ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1607, NameUz = "ЧОРТОҚ ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1608, NameUz = "ЯНГИҚЎРҒОН ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1609, NameUz = "КОСОНСОЙ ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1610, NameUz = "ЧУСТ ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1611, NameUz = "ПОП ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1612, NameUz = "ТЎРАҚЎРҒОН ТУМАНИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1613, NameUz = "НАМАНГАН ШАҲРИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1614, NameUz = "КОСОНСОЙ ШАҲРИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1615, NameUz = "УЧҚЎРҒОН ШАҲРИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1616, NameUz = "ЧОРТОҚ ШАҲРИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1617, NameUz = "ЧУСТ ШАҲРИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1618, NameUz = "ХАҚҚУЛОБОД ШАҲРИ", RegionId = 16, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1701, NameUz = "АНДИЖОН ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1702, NameUz = "ОЛТИНКЎЛ ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1703, NameUz = "АСАКА ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1704, NameUz = "БАЛИҚЧИ ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1705, NameUz = "БЎЗ ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1706, NameUz = "УЛУҒНОР ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1707, NameUz = "ШАХРИХОН ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1708, NameUz = "ҚЎРҒОНТЕПА ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1410, NameUz = "ТАЙЛОҚ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1411, NameUz = "БУЛУНҒУР ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1412, NameUz = "ГЎЗАЛКЕНТ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1718, NameUz = "ШАҲРИХОН ШАҲРИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1719, NameUz = "ҚОРАСУВ ШАҲРИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1801, NameUz = "ЧИРОҚЧИ ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1802, NameUz = "КОСОН ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1803, NameUz = "ШАҲРИСАБЗ ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1804, NameUz = "ДЕҲҚОНОБОД ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1413, NameUz = "САМАРҚАНД ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1414, NameUz = "ҚЎШРАБОД ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1415, NameUz = "ПАЙАРИҚ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1416, NameUz = "ЧЕЛАК ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1417, NameUz = "САМАРҚАНД ШАҲРИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1418, NameUz = "БОҒИШАМОЛ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1419, NameUz = "ТЕМИРЙЎЛ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1420, NameUz = "ОҚТОШ ШАҲРИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1421, NameUz = "КАТТАҚЎРҒОН ШАҲРИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1422, NameUz = "УРГУТ ШАҲРИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1423, NameUz = "СИЁБ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1501, NameUz = "КИРГУЛИ ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1502, NameUz = "ФАРҒОНА ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1503, NameUz = "ҚУВА ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1504, NameUz = "ТОШЛОҚ ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1505, NameUz = "ОХУНБОБОЕВ ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1506, NameUz = "ЁЗЁВОН ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1507, NameUz = "ОЛТИАРИҚ ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1508, NameUz = "БОҒДОД ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1509, NameUz = "БУВАЙДА ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1510, NameUz = "УЧКЎПРИК ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1511, NameUz = "РИШТОН ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1512, NameUz = "ДАНҒАРА ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1513, NameUz = "ФУРҚАТ ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1002, NameUz = "СОБИР РАХИМОВ ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1003, NameUz = "МИРЗО УЛУҒБЕК ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1005, NameUz = "ЯККАСАРОЙ ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1006, NameUz = "ШАЙХОНТОХУР ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1007, NameUz = "ЧИЛОНЗОР ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1008, NameUz = "СИРҒАЛИ ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1009, NameUz = "МИРОБОД ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1010, NameUz = "ЮНУСОБОД ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1011, NameUz = "БЕКТЕМИР ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1101, NameUz = "ЯНГИЙЎЛ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1102, NameUz = "ЗАНГИОТА ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1103, NameUz = "ПИСКЕНТ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1104, NameUz = "ПАРКЕНТ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1105, NameUz = "ЎРТАЧИРЧИҚ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1106, NameUz = "ОҚҚЎРҒОН ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 739001100, NameUz = "ШАРОФ РАШИДОВ ТУМАНИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 739001120, NameUz = "НУРАФШОН ШАҲРИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 739001121, NameUz = "ОҲАНГАРОН ШАҲРИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1107, NameUz = "ҚУЙИЧИРЧИҚ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1108, NameUz = "ҚИБРАЙ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1109, NameUz = "ТОШКЕНТ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1110, NameUz = "ОХАНГАРОН ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1111, NameUz = "БЕКОБОД ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1112, NameUz = "БЎСТОНЛИҚ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1113, NameUz = "БЎКА ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1114, NameUz = "ЮҚОРИЧИРЧИҚ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1115, NameUz = "ЧИНОЗ ТУМАНИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1116, NameUz = "АНГРЕН ШАҲРИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1117, NameUz = "БЕКОБОД ШАҲРИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1118, NameUz = "ОЛМАЛИК ШАҲРИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1119, NameUz = "ОХАНГОРОН ШАҲРИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1120, NameUz = "ЧИРЧИҚ ШАҲРИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1121, NameUz = "ЯНГИОБОД ШАҲРИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1814, NameUz = "МИРИШКОР ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1012, NameUz = "ОЛМАЗОР ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2434, NameUz = "ҚЎШТЕПА ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1122, NameUz = "ЯНГИЙЎЛ ШАҲРИ", RegionId = 11, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1201, NameUz = "САЙХУНОБОД ТУМАНИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2203, NameUz = "ГУРЛАН ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1709, NameUz = "ЖАЛАҚУДУҚ ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1710, NameUz = "ХЎЖАОБОД ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1711, NameUz = "МАРХАМАТ ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1712, NameUz = "ИЗБОСКАН ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1713, NameUz = "БУЛОҚБОШИ ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1714, NameUz = "ПАХТАОБОД ТУМАНИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1715, NameUz = "АНДИЖОН ШАҲРИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1716, NameUz = "АСАКА ШАҲРИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1717, NameUz = "ХОНОБОД ШАҲРИ", RegionId = 17, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1806, NameUz = "ЯККАБОҒ ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1807, NameUz = "БАХОРИСТОН ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1808, NameUz = "ҒУЗОР ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1809, NameUz = "ҚАРШИ ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1810, NameUz = "НИШОН ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1811, NameUz = "КИТОБ ТУМАНИ", RegionId = 18, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1314, NameUz = "ЖИЗЗАХ ШАҲРИ", RegionId = 13, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1401, NameUz = "НАРПАЙ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1402, NameUz = "НУРОБОД ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1403, NameUz = "ЖОМБОЙ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1404, NameUz = "УРГУТ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1405, NameUz = "ПАХТАЧИ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1406, NameUz = "КАТТАҚЎРҒОН ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1407, NameUz = "ОҚДАРЁ ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1408, NameUz = "ИШТИХОН ТУМАНИ", RegionId = 14, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1915, NameUz = "БАНДИХОН ТУМАНИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1916, NameUz = "ТЕРМИЗ ШАҲРИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1917, NameUz = "ДЕНОВ ШАҲРИ", RegionId = 19, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2001, NameUz = "РОМИТАН ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2002, NameUz = "ВОБКЕНТ ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2003, NameUz = "ПЕШКУ ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2004, NameUz = "ОЛОТ ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2005, NameUz = "ЖОНДОР ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2006, NameUz = "ҚОРАКЎЛ ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2007, NameUz = "ШОФИРКОН ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2008, NameUz = "ҚОРОВУЛБОЗОР ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2009, NameUz = "ГАЗЛИ ШАҲРИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2010, NameUz = "БУХОРО ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2011, NameUz = "КОГОН ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2012, NameUz = "ҒИЖДУВОН ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2013, NameUz = "БУХОРО ШАҲРИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2014, NameUz = "ҒИЖДУВОН ШАҲРИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2015, NameUz = "КОГОН ШАҲРИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2016, NameUz = "Ф.ХЎЖАЕВ ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2017, NameUz = "ТЎҚИМАЧИ ТУМАНИ", RegionId = 20, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2101, NameUz = "УЧҚУДУҚ ТУМАНИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2102, NameUz = "КОНИМЕХ ТУМАНИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2104, NameUz = "ТОМДИ ТУМАНИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2105, NameUz = "НАВБАҲОР ТУМАНИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2106, NameUz = "НАВОИЙ ТУМАНИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2107, NameUz = "НУРОТА ТУМАНИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2108, NameUz = "ХАТИРЧИ ТУМАНИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2109, NameUz = "ҚИЗИЛТЕПА ТУМАНИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2110, NameUz = "КАРМАНА ТУМАНИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2111, NameUz = "НАВОИЙ ШАҲРИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2112, NameUz = "ЗАРАФШОН ШАҲРИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1215, NameUz = "САРДОБА ТУМАНИ", RegionId = 12, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 739001080, NameUz = "ЯШНОБОД ТУМАНИ", RegionId = 10, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2113, NameUz = "УЧҚУДУҚ ШАҲРИ", RegionId = 21, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2201, NameUz = "ХАЗОРАСП ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 2202, NameUz = "ЯНГИАРИҚ ТУМАНИ", RegionId = 22, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1514, NameUz = "ЎЗБЕКИСТОН ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1515, NameUz = "БЕШАРИҚ ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1516, NameUz = "СЎХ ТУМАНИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1517, NameUz = "ҚУВАСОЙ ШАҲРИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<spDistrict>().HasData(new spDistrict() { Id = 1518, NameUz = "ҚУВА ШАҲРИ", RegionId = 15, Status = 1, CreateUser = g, CreateDate = d1 });
            #endregion

            #region spStatus Data Init
            modelBuilder.Entity<spStatus>().HasData(new { Id = 1, NameRu = "Активный", NameLt = "Amalda", NameUz = "Амалда", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spStatus>().HasData(new { Id = 2, NameRu = "Архив", NameLt = "Arhiv", NameUz = "Архив", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spStatus>().HasData(new { Id = 5, NameRu = "Временно отключен", NameLt = "Vaqtincha o'chirilgan", NameUz = "Вақтинча ўчирилган", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spStatus>().HasData(new { Id = 6, NameRu = "Не работает", NameLt = "Ishlamaydi", NameUz = "Ишламайди", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spStatus>().HasData(new { Id = 9, NameRu = "Удалено", NameLt = "O`chrilgan", NameUz = "Ўчирилган", CreateDate = d1, CreateUser = g, Status = 1 });

            #endregion

            modelBuilder.Entity<spCarBrand>().HasData(new { Id = 1, Name = "BMV", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spCarBrand>().HasData(new { Id = 2, Name = "MERS", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spCarBrand>().HasData(new { Id = 3, Name = "GM", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spCarBrand>().HasData(new { Id = 4, Name = "BYD", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spCarBrand>().HasData(new { Id = 5, Name = "CHERY", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spCarBrand>().HasData(new { Id = 6, Name = "LI", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spCarBrand>().HasData(new { Id = 7, Name = "GAZ", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spCarBrand>().HasData(new { Id = 8, Name = "LAMBO", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spCarBrand>().HasData(new { Id = 9, Name = "RENO", CreateDate = d1, CreateUser = g, Status = 1 });


            modelBuilder.Entity<spCarModel>().HasData(
                new spCarModel { Id = 1, BrandId = 3, Name = "SPARK", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 2, BrandId = 1, Name = "3-SERIES", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 3, BrandId = 4, Name = "TANG", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 4, BrandId = 2, Name = "E-CLASS", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 5, BrandId = 5, Name = "QQ", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 6, BrandId = 6, Name = "XIAO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 7, BrandId = 7, Name = "GAZELLE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 8, BrandId = 8, Name = "HURACAN", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 9, BrandId = 9, Name = "LOGAN", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 10, BrandId = 1, Name = "X5", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 11, BrandId = 3, Name = "AVEO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 12, BrandId = 1, Name = "5-SERIES", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 13, BrandId = 4, Name = "ENCORE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 14, BrandId = 2, Name = "S-CLASS", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 15, BrandId = 5, Name = "TIGGO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 16, BrandId = 6, Name = "XING", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 17, BrandId = 7, Name = "SOBOL", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 18, BrandId = 8, Name = "GALLARDO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 19, BrandId = 9, Name = "SANDERO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 20, BrandId = 1, Name = "X7", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 21, BrandId = 3, Name = "MALIBU", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 22, BrandId = 1, Name = "7-SERIES", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 23, BrandId = 4, Name = "REGAL", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 24, BrandId = 2, Name = "GLC", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 25, BrandId = 5, Name = "ARRIZO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 26, BrandId = 6, Name = "E6", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 27, BrandId = 7, Name = "TIGR", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 28, BrandId = 8, Name = "URUS", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 29, BrandId = 9, Name = "DUSTER", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 30, BrandId = 1, Name = "X1", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 31, BrandId = 3, Name = "CRUZE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 32, BrandId = 1, Name = "X6", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 33, BrandId = 4, Name = "ENVISION", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 34, BrandId = 2, Name = "GLE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 35, BrandId = 5, Name = "QQ3", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 36, BrandId = 6, Name = "XUAN", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 37, BrandId = 7, Name = "VOLGA", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 38, BrandId = 8, Name = "ASTERION", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 39, BrandId = 9, Name = "KAPTUR", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 40, BrandId = 1, Name = "X3", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 41, BrandId = 3, Name = "AVEO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 42, BrandId = 1, Name = "X4", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 43, BrandId = 4, Name = "VERANO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 44, BrandId = 2, Name = "GLA", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 45, BrandId = 5, Name = "QQ6", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 46, BrandId = 6, Name = "XUE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 47, BrandId = 7, Name = "NEXT", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 48, BrandId = 8, Name = "HURACAN EVO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 49, BrandId = 9, Name = "LATITUDE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 50, BrandId = 1, Name = "X2", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 51, BrandId = 3, Name = "SPARK", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 52, BrandId = 1, Name = "I3", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 53, BrandId = 4, Name = "LACROSSE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 54, BrandId = 2, Name = "GLB", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 55, BrandId = 5, Name = "TIGGO 2", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 56, BrandId = 6, Name = "XIAO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 57, BrandId = 7, Name = "3110", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 58, BrandId = 8, Name = "ASTERION LPI 910-4", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 59, BrandId = 9, Name = "MEGANE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 60, BrandId = 1, Name = "I8", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 61, BrandId = 3, Name = "MALIBU", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 62, BrandId = 1, Name = "I4", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 63, BrandId = 4, Name = "EXCELLE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 64, BrandId = 2, Name = "GLS", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 65, BrandId = 5, Name = "TIGGO 3", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 66, BrandId = 6, Name = "XIAO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 67, BrandId = 7, Name = "2752", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 68, BrandId = 8, Name = "CENTENARIO", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 69, BrandId = 9, Name = "KOLEOS", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 70, BrandId = 1, Name = "I9", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 71, BrandId = 3, Name = "CRUZE", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 72, BrandId = 1, Name = "I5", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 73, BrandId = 4, Name = "ROYAUM", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 74, BrandId = 2, Name = "CLA", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 75, BrandId = 5, Name = "ARRIZO 5", CreateDate = d1, CreateUser = g, Status = 1 },
                new spCarModel { Id = 76, BrandId = 6, Name = "XIAO", CreateDate = d1, CreateUser = g, Status = 1 }
              );


            var cars = new List<tbCar>
            {
                new tbCar { Id = 1, PlateNumber = "ABC123", VinCode = "VINCODE123", EVBatteryCapacity = 100, ChargingPerMinute = 0.5, BrandId = 3, ModelId = 1, DriverId = g },
                new tbCar { Id = 2, PlateNumber = "DEF456", VinCode = "VINCODE456", EVBatteryCapacity = 120, ChargingPerMinute = 0.6, BrandId = 1, ModelId = 2, DriverId = g },
                new tbCar { Id = 3, PlateNumber = "GHI789", VinCode = "VINCODE789", EVBatteryCapacity = 110, ChargingPerMinute = 0.7, BrandId = 4, ModelId = 3, DriverId = g },
                new tbCar { Id = 4, PlateNumber = "JKL012", VinCode = "VINCODE012", EVBatteryCapacity = 130, ChargingPerMinute = 0.8, BrandId = 2, ModelId = 4, DriverId = g },
                new tbCar { Id = 5, PlateNumber = "MNO345", VinCode = "VINCODE345", EVBatteryCapacity = 140, ChargingPerMinute = 0.9, BrandId = 5, ModelId = 5, DriverId = g },
                new tbCar { Id = 6, PlateNumber = "PQR678", VinCode = "VINCODE678", EVBatteryCapacity = 150, ChargingPerMinute = 1.0, BrandId = 6, ModelId = 6, DriverId = g },
                new tbCar { Id = 7, PlateNumber = "STU901", VinCode = "VINCODE901", EVBatteryCapacity = 160, ChargingPerMinute = 1.1, BrandId = 7, ModelId = 7, DriverId = g },
                new tbCar { Id = 8, PlateNumber = "VWX234", VinCode = "VINCODE234", EVBatteryCapacity = 170, ChargingPerMinute = 1.2, BrandId = 8, ModelId = 8, DriverId = g },
                new tbCar { Id = 9, PlateNumber = "YZA567", VinCode = "VINCODE567", EVBatteryCapacity = 180, ChargingPerMinute = 1.3, BrandId = 9, ModelId = 9, DriverId = g },
                new tbCar { Id = 10, PlateNumber = "BCD890", VinCode = "VINCODE890", EVBatteryCapacity = 190, ChargingPerMinute = 1.4, BrandId = 1, ModelId = 10, DriverId = g },
                new tbCar { Id = 11, PlateNumber = "EFG123", VinCode = "VINCODE123", EVBatteryCapacity = 200, ChargingPerMinute = 1.5, BrandId = 3, ModelId = 11, DriverId = g },
                new tbCar { Id = 12, PlateNumber = "HIJ456", VinCode = "VINCODE456", EVBatteryCapacity = 210, ChargingPerMinute = 1.6, BrandId = 1, ModelId = 12, DriverId = g },
                new tbCar { Id = 13, PlateNumber = "KLM789", VinCode = "VINCODE789", EVBatteryCapacity = 220, ChargingPerMinute = 1.7, BrandId = 4, ModelId = 13, DriverId = g },
                new tbCar { Id = 14, PlateNumber = "NOP012", VinCode = "VINCODE012", EVBatteryCapacity = 230, ChargingPerMinute = 1.8, BrandId = 2, ModelId = 14, DriverId = g },
                new tbCar { Id = 15, PlateNumber = "QRS345", VinCode = "VINCODE345", EVBatteryCapacity = 240, ChargingPerMinute = 1.9, BrandId = 5, ModelId = 15, DriverId = g },
                new tbCar { Id = 16, PlateNumber = "TUV678", VinCode = "VINCODE678", EVBatteryCapacity = 250, ChargingPerMinute = 2.0, BrandId = 6, ModelId = 16, DriverId = g },
                new tbCar { Id = 17, PlateNumber = "WXYZ01", VinCode = "VINCODE901", EVBatteryCapacity = 260, ChargingPerMinute = 2.1, BrandId = 7, ModelId = 17, DriverId = g },
                new tbCar { Id = 18, PlateNumber = "YZA234", VinCode = "VINCODE234", EVBatteryCapacity = 270, ChargingPerMinute = 2.2, BrandId = 8, ModelId = 18, DriverId = g },
                new tbCar { Id = 19, PlateNumber = "BCD567", VinCode = "VINCODE567", EVBatteryCapacity = 280, ChargingPerMinute = 2.3, BrandId = 9, ModelId = 19, DriverId = g },
                new tbCar { Id = 20, PlateNumber = "EFG890", VinCode = "VINCODE890", EVBatteryCapacity = 290, ChargingPerMinute = 2.4, BrandId = 1, ModelId = 20, DriverId = g }
            };
            modelBuilder.Entity<tbCar>().HasData(cars);

            var queueDrivers = new List<tbQueueDriver>
            {
                new tbQueueDriver { Id = 1, PhoneNumber = "1234567890", PlateNumber = "ABC123", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(1), UserInfo = "UserInfo1", Comment = "Comment1", CancelReason = "CancelReason1", CreateUser = g, Status = 1, ConnectorId = 1, CarId = 1 },
                new tbQueueDriver { Id = 2, PhoneNumber = "2345678901", PlateNumber = "DEF456", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(2), UserInfo = "UserInfo2", Comment = "Comment2", CancelReason = "CancelReason2", CreateUser = g, Status = 1, ConnectorId = 2, CarId = 2 },
                new tbQueueDriver { Id = 3, PhoneNumber = "3456789012", PlateNumber = "GHI789", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(3), UserInfo = "UserInfo3", Comment = "Comment3", CancelReason = "CancelReason3", CreateUser = g, Status = 1, ConnectorId = 3, CarId = 3 },
                new tbQueueDriver { Id = 4, PhoneNumber = "4567890123", PlateNumber = "JKL012", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(4), UserInfo = "UserInfo4", Comment = "Comment4", CancelReason = "CancelReason4", CreateUser = g, Status = 1, ConnectorId = 4, CarId = 4 },
                new tbQueueDriver { Id = 5, PhoneNumber = "5678901234", PlateNumber = "MNO345", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(5), UserInfo = "UserInfo5", Comment = "Comment5", CancelReason = "CancelReason5", CreateUser = g, Status = 1, ConnectorId = 5, CarId = 5 },
                new tbQueueDriver { Id = 6, PhoneNumber = "6789012345", PlateNumber = "PQR678", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(6), UserInfo = "UserInfo6", Comment = "Comment6", CancelReason = "CancelReason6", CreateUser = g, Status = 1, ConnectorId = 6, CarId = 6 },
                new tbQueueDriver { Id = 7, PhoneNumber = "7890123456", PlateNumber = "STU901", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(7), UserInfo = "UserInfo7", Comment = "Comment7", CancelReason = "CancelReason7", CreateUser = g, Status = 1, ConnectorId = 7, CarId = 7 },
                new tbQueueDriver { Id = 8, PhoneNumber = "8901234567", PlateNumber = "VWX234", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(8), UserInfo = "UserInfo8", Comment = "Comment8", CancelReason = "CancelReason8", CreateUser = g, Status = 1, ConnectorId = 8, CarId = 8 },
                new tbQueueDriver { Id = 9, PhoneNumber = "9012345678", PlateNumber = "YZA567", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(9), UserInfo = "UserInfo9", Comment = "Comment9", CancelReason = "CancelReason9", CreateUser = g, Status = 1, ConnectorId = 9, CarId = 9 },
                new tbQueueDriver { Id = 10, PhoneNumber = "0123456789", PlateNumber = "BCD890", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(10), UserInfo = "UserInfo10", Comment = "Comment10", CancelReason = "CancelReason10", CreateUser = g, Status = 1, ConnectorId = 10, CarId = 10 },
                new tbQueueDriver { Id = 11, PhoneNumber = "1234567890", PlateNumber = "EFG123", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(11), UserInfo = "UserInfo11", Comment = "Comment11", CancelReason = "CancelReason11", CreateUser = g, Status = 1, ConnectorId = 11, CarId = 11 },
                new tbQueueDriver { Id = 12, PhoneNumber = "2345678901", PlateNumber = "HIJ456", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(12), UserInfo = "UserInfo12", Comment = "Comment12", CancelReason = "CancelReason12", CreateUser = g, Status = 1, ConnectorId = 12, CarId = 12 },
                new tbQueueDriver { Id = 13, PhoneNumber = "3456789012", PlateNumber = "KLM789", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(13), UserInfo = "UserInfo13", Comment = "Comment13", CancelReason = "CancelReason13", CreateUser = g, Status = 1, ConnectorId = 13, CarId = 13 },
                new tbQueueDriver { Id = 14, PhoneNumber = "4567890123", PlateNumber = "NOP012", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(14), UserInfo = "UserInfo14", Comment = "Comment14", CancelReason = "CancelReason14", CreateUser = g, Status = 1, ConnectorId = 14, CarId = 14 },
                new tbQueueDriver { Id = 15, PhoneNumber = "5678901234", PlateNumber = "QRS345", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(15), UserInfo = "UserInfo15", Comment = "Comment15", CancelReason = "CancelReason15", CreateUser = g, Status = 1, ConnectorId = 15, CarId = 15 },
                new tbQueueDriver { Id = 16, PhoneNumber = "6789012345", PlateNumber = "TUV678", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(16), UserInfo = "UserInfo16", Comment = "Comment16", CancelReason = "CancelReason16", CreateUser = g, Status = 1, ConnectorId = 16, CarId = 16 },
                new tbQueueDriver { Id = 17, PhoneNumber = "7890123456", PlateNumber = "WXYZ01", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(17), UserInfo = "UserInfo17", Comment = "Comment17", CancelReason = "CancelReason17", CreateUser = g, Status = 1, ConnectorId = 17, CarId = 17 },
                new tbQueueDriver { Id = 18, PhoneNumber = "8901234567", PlateNumber = "YZA234", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(18), UserInfo = "UserInfo18", Comment = "Comment18", CancelReason = "CancelReason18", CreateUser = g, Status = 1, ConnectorId = 18, CarId = 18 },
                new tbQueueDriver { Id = 19, PhoneNumber = "9012345678", PlateNumber = "BCD567", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(19), UserInfo = "UserInfo19", Comment = "Comment19", CancelReason = "CancelReason19", CreateUser = g, Status = 1, ConnectorId = 19, CarId = 19 },
                new tbQueueDriver { Id = 20, PhoneNumber = "0123456789", PlateNumber = "EFG890", BeginTime = DateTime.Now, EndTime = DateTime.Now.AddHours(20), UserInfo = "UserInfo20", Comment = "Comment20", CancelReason = "CancelReason20", CreateUser = g, Status = 2, ConnectorId = 20, CarId = 20 }
            };

            modelBuilder.Entity<tbQueueDriver>().HasData(queueDrivers);


        }

    }

}
