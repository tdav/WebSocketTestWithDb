using App.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace App.Database.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var g = Guid.Parse("1c095b27-d060-4ed1-9167-4c9745196e2e");
            var rg = Guid.Parse("1c095b27-d060-4ed1-9167-4c9745196e2e");
            var d1 = DateTime.Parse("2023-10-09");

            modelBuilder.Entity<spInternetAccessType>().HasData(new spInternetAccessType() { Id = 1, Name = "Сим карта" });
            modelBuilder.Entity<spInternetAccessType>().HasData(new spInternetAccessType() { Id = 2, Name = "Кабел" });

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

            #region spPaymentType
            modelBuilder.Entity<spPaymentType>().HasData(new { Id = 1, NameUz = "PayMe", NameLt = "PayMe", NameRu = "PayMe", NameEn = "PayMe", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spPaymentType>().HasData(new { Id = 2, NameUz = "Click", NameLt = "Click", NameRu = "Click", NameEn = "Click", CreateDate = d1, CreateUser = g, Status = 1 });
            #endregion

            #region spPromoCodeType
            modelBuilder.Entity<spPromoCodeType>().HasData(new { Id = 1, NameUz = "Сумма бўичв", NameLt = "Summa bo`yicha", NameRu = "по Сумме", NameEn = "by Amout", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spPromoCodeType>().HasData(new { Id = 2, NameUz = "Фоиз бўича", NameLt = "Foiz bo`yicha", NameRu = "по Проценту", NameEn = "by Percent", CreateDate = d1, CreateUser = g, Status = 1 });
            #endregion

            #region spPaymentStatus
            modelBuilder.Entity<spPaymentStatus>().HasData(new { Id = 1, NameEn = "Pending", NameRu = "В ожидании", NameUz = "Кутилмоқда", NameLt = "Kutilmoqda", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spPaymentStatus>().HasData(new { Id = 2, NameEn = "Completed", NameRu = "Завершенный", NameUz = "Тугатилган", NameLt = "Tugatilgan", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spPaymentStatus>().HasData(new { Id = 3, NameEn = "Refunded", NameRu = "Возвращено", NameUz = "Қайтарилган", NameLt = "Qaytarilgan", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spPaymentStatus>().HasData(new { Id = 4, NameEn = "Failed", NameRu = "Неуспешный", NameUz = "Ҳато", NameLt = "Xato", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spPaymentStatus>().HasData(new { Id = 5, NameEn = "Abandoned", NameRu = "Заброшенный", NameUz = "Тўланмаган", NameLt = "To`lanmagan", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spPaymentStatus>().HasData(new { Id = 6, NameEn = "Revoked", NameRu = "Отозван", NameUz = "Қайтарилган", NameLt = "Qaytarilgan", CreateDate = d1, CreateUser = g, Status = 1 });
            modelBuilder.Entity<spPaymentStatus>().HasData(new { Id = 7, NameEn = "Cancelled", NameRu = "Отменено", NameUz = "Бекор қилинган", NameLt = "Bekor qilingan", CreateDate = d1, CreateUser = g, Status = 1 });
            #endregion

            #region spUnit
            modelBuilder.Entity<spUnit>().HasData(new spUnit
            {
                Id = 1,
                ShortName = "C",
                NameUz = "Целсий",
                NameEn = "Celsius",
                NameRu = "Целсий",
                NameLt = "Selsiy",
                CreateDate = d1,
                CreateUser = g,
                Status = 1
            });

            modelBuilder.Entity<spUnit>().HasData(new spUnit
            {
                Id = 2,
                ShortName = "A",
                NameUz = "Ампер",
                NameRu = "Ампер",
                NameLt = "Amper",
                NameEn = "Amper",
                CreateDate = d1,
                CreateUser = g,
                Status = 1
            });

            modelBuilder.Entity<spUnit>().HasData(new spUnit
            {
                Id = 3,
                ShortName = "%",
                NameUz = "Фоиз",
                NameRu = "Процент",
                NameLt = "Foiz",
                NameEn = "Percent",
                CreateDate = d1,
                CreateUser = g,
                Status = 1
            });

            modelBuilder.Entity<spUnit>().HasData(new spUnit
            {
                Id = 4,
                ShortName = "Вт",
                NameUz = "Ватт",
                NameRu = "Ватт",
                NameLt = "Wat",
                NameEn = "Watt",
                CreateDate = d1,
                CreateUser = g,
                Status = 1
            });

            modelBuilder.Entity<spUnit>().HasData(new spUnit
            {
                Id = 5,
                ShortName = "В",
                NameUz = "Вольт",
                NameRu = "Вольт",
                NameLt = "Volt",
                NameEn = "Volt",
                CreateDate = d1,
                CreateUser = g,
                Status = 1
            });

            modelBuilder.Entity<spUnit>().HasData(new spUnit
            {
                Id = 6,
                ShortName = "Вт/ч",
                NameUz = "Ватт-соат",
                NameRu = "Ватт-час",
                NameLt = "Vat-soat",
                NameEn = "watt-hour",
                CreateDate = d1,
                CreateUser = g,
                Status = 1
            });

            modelBuilder.Entity<spUnit>().HasData(new spUnit
            {
                Id = 7,
                ShortName = "кВт/ч",
                NameUz = "Киловатт-соат",
                NameRu = "Киловатт-час",
                NameLt = "Kilovat-soat",
                NameEn = "Kilowatt-hour",
                CreateDate = d1,
                CreateUser = g,
                Status = 1
            });
            #endregion

            #region spSmsStatus
            modelBuilder.Entity<spSmsStatus>().HasData(new spSmsStatus { Id = 1, NameEn = "SMS delivered", NameRu = "СМС доставлено", NameUz = "СМС ЕТКАЗИЛДИ", NameLt = "SMS etkazildi", Status = 1, CreateDate = d1, CreateUser = g });
            modelBuilder.Entity<spSmsStatus>().HasData(new spSmsStatus { Id = 2, NameEn = "Send error", NameRu = "Ошибка отправки", NameUz = "Юборишда хато", NameLt = "Yuborishda хato", Status = 1, CreateDate = d1, CreateUser = g });
            modelBuilder.Entity<spSmsStatus>().HasData(new spSmsStatus { Id = 3, NameEn = "Pending", NameRu = "В ожидании", NameUz = "Кутилмоқда", NameLt = "Kutilmoqda", Status = 1, CreateDate = d1, CreateUser = g });
            #endregion

            #region spConnectorType
            modelBuilder.Entity<spConnectorType>().HasData(new spConnectorType()
            {
                Id = 1,
                Name = "TYPE 1 J1772",
                Type = "AC",
                Country = "Japon",
                ImageUrl = "TYPE_1_J1772_AC_Japon.png",
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<spConnectorType>().HasData(new spConnectorType()
            {
                Id = 2,
                Name = "GB/T",
                Type = "AC",
                Country = "China",
                ImageUrl = "GB_T_AC_China.png",
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<spConnectorType>().HasData(new spConnectorType()
            {
                Id = 3,
                Name = "TYPE 1 J1772",
                Type = "AC",
                Country = "America",
                ImageUrl = "TYPE_1_J1772_AC_America.png",
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<spConnectorType>().HasData(new spConnectorType()
            {
                Id = 4,
                Name = "TYPE 2",
                Type = "AC",
                Country = "Europe",
                ImageUrl = "TYPE_2_AC_Europe.png",
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<spConnectorType>().HasData(new spConnectorType()
            {
                Id = 5,
                Name = "CHAdeMO",
                Type = "DC",
                Country = "Japon",
                ImageUrl = "CHAdeMO_Japon.png",
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<spConnectorType>().HasData(new spConnectorType()
            {
                Id = 6,
                Name = "GB/T",
                Type = "DC",
                Country = "China",
                ImageUrl = "GB_T_DC_China.png",
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<spConnectorType>().HasData(new spConnectorType()
            {
                Id = 7,
                Name = "CCS-TYPE 1",
                Type = "DC",
                Country = "America",
                ImageUrl = "CCS-TYPE_1_America.png",
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<spConnectorType>().HasData(new spConnectorType()
            {
                Id = 8,
                Name = "CCS-TYPE 2",
                Type = "DC",
                Country = "Europe",
                ImageUrl = "CCS-TYPE_2_Europe.png",
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<spConnectorType>().HasData(new spConnectorType()
            {
                Id = 9,
                Name = "TESLA",
                Type = "DC",
                Country = "Europe",
                ImageUrl = "TESLA.png",
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });
            #endregion

            #region spStatus Data Init
            modelBuilder.Entity<tbChargePoint>().HasData(new tbChargePoint()
            {
                Id = 1,
                ChargePointId = "TEST1234",
                Name = "TEST1234",
                Latitude = 41.284135,
                Longitude = 69.211267,
                RegionId = 10,
                DistrictId = 1007,
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<tbChargePoint>().HasData(new tbChargePoint()
            {
                Id = 2,
                ChargePointId = "TEST3333",
                Name = "TEST3333",
                Latitude = 41.313863,
                Longitude = 69.222854,
                RegionId = 10,
                DistrictId = 1006,
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<tbChargePoint>().HasData(new tbChargePoint()
            {
                Id = 3,
                ChargePointId = "22E05701",
                Name = "22E05701",
                Latitude = 41.331731,
                Longitude = 69.301874,
                RegionId = 10,
                DistrictId = 1002,
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });
            #endregion

            #region tbChargeTag
            modelBuilder.Entity<tbChargeTag>().HasData(new tbChargeTag()
            {
                ExpiryDate = d1.AddYears(10),
                TagId = "B4A63CDF",
                TagName = "B4A63CDF",
                Blocked = false,
                Status = 1,
                CreateUser = g,
                CreateDate = d1,
            });

            modelBuilder.Entity<tbChargeTag>().HasData(new tbChargeTag()
            {
                ExpiryDate = d1.AddYears(10),
                TagId = "998278960",
                TagName = "TASIBAEYEV DAVRON",
                Blocked = false,
                Status = 1,
                CreateUser = g,
                ParentTagId = "d4b563be-8926-46e8-b377-3de7bf096c08",
                CreateDate = d1,
            });

            modelBuilder.Entity<tbChargeTag>().HasData(new tbChargeTag()
            {
                ExpiryDate = d1.AddYears(90),
                TagId = "000000000",
                TagName = "Ручная активация",
                Blocked = false,
                Status = 1,
                CreateUser = g,
                ParentTagId = "9613d012-c4f5-4986-b885-ca5863e12344",
                CreateDate = d1,
            });

            #endregion

            modelBuilder.Entity<spServiceType>().HasData(new spServiceType() { Id = 1, NameRu = "Зарядка автомобильная", NameEn = "Charging the car", NameLt = "Avtomobilni zaryadlash", NameUz = "Автомобилни зарядлаш", Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<tbPrice>().HasData(new tbPrice() { Id = 1, Summa = 2000, ServiceTypeId = 1, ActivateDate = DateTime.Parse("2023-01-01 00:00:00"), Status = 1, CreateUser = g, CreateDate = d1 });
            modelBuilder.Entity<tbPrice>().HasData(new tbPrice() { Id = 2, Summa = 5000, ServiceTypeId = 1, ActivateDate = DateTime.Parse("2024-01-01 00:00:00"), Status = 1, CreateUser = g, CreateDate = d1 });

            modelBuilder.Entity<JsonDataConnectionDescription>().HasData(new JsonDataConnectionDescription() { Id = 1, Name = "JsonProducts", DisplayName = "Json Data", ConnectionString = "Uri=Data/nwind.json" });
            modelBuilder.Entity<SqlDataConnectionDescription>().HasData(new SqlDataConnectionDescription() { Id = 2, Name = "DBConnection", DisplayName = "Ocpp Data Connection", ConnectionString = "XpoProvider=Postgres; Server=localhost; Database=ocpp_trianon_db; User ID=postgres; Password=1; Encoding=UNICODE" });

        }

    }

}
