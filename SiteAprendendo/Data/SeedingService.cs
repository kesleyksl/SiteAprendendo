using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiteAprendendo.Models;
using SiteAprendendo.Models.Enums;

namespace SiteAprendendo.Data
{
    public class SeedingService
    {
        private SiteAprendendoContext _context;

        public SeedingService(SiteAprendendoContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departament.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB ja foi populado
            }
            Departament d1 = new Departament(1, "Computers");
            Departament d2 = new Departament(2, "Eletronics");
            Departament d3 = new Departament(3, "Fashion");
            Departament d4 = new Departament(4, "Book");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Gray", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "alexpink@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);


            SallesRecords r1 = new SallesRecords(1, new DateTime(2018, 09, 25), 11000.0, SalesStatus.Billed, s1);
            SallesRecords r2 = new SallesRecords(2, new DateTime(2018, 09, 4), 7000.0, SalesStatus.Billed, s5);
            SallesRecords r3 = new SallesRecords(3, new DateTime(2018, 09, 13), 4000.0, SalesStatus.Canceled, s4);
            SallesRecords r4 = new SallesRecords(4, new DateTime(2018, 09, 1), 8000.0, SalesStatus.Billed, s1);
            SallesRecords r5 = new SallesRecords(5, new DateTime(2018, 09, 21), 3000.0, SalesStatus.Billed, s3);
            SallesRecords r6 = new SallesRecords(6, new DateTime(2018, 09, 15), 2000.0, SalesStatus.Billed, s1);
            SallesRecords r7 = new SallesRecords(7, new DateTime(2018, 09, 28), 13000.0, SalesStatus.Billed, s2);
            SallesRecords r8 = new SallesRecords(8, new DateTime(2018, 09, 11), 4000.0, SalesStatus.Billed, s4);
            SallesRecords r9 = new SallesRecords(9, new DateTime(2018, 09, 14), 11000.0, SalesStatus.Pending, s6);
            SallesRecords r10 = new SallesRecords(10, new DateTime(2018, 09, 7), 9000.0, SalesStatus.Billed, s6);
            SallesRecords r11 = new SallesRecords(11, new DateTime(2018, 09, 13), 6000.0, SalesStatus.Billed, s2);
            SallesRecords r12 = new SallesRecords(12, new DateTime(2018, 09, 25), 7000.0, SalesStatus.Pending, s3);
            SallesRecords r13 = new SallesRecords(13, new DateTime(2018, 09, 29), 10000.0, SalesStatus.Billed, s4);
            SallesRecords r14 = new SallesRecords(14, new DateTime(2018, 09, 4), 3000.0, SalesStatus.Billed, s5);
            SallesRecords r15 = new SallesRecords(15, new DateTime(2018, 09, 12), 4000.0, SalesStatus.Billed, s1);
            SallesRecords r16 = new SallesRecords(16, new DateTime(2018, 10, 5), 2000.0, SalesStatus.Billed, s4);
            SallesRecords r17 = new SallesRecords(17, new DateTime(2018, 10, 1), 12000.0, SalesStatus.Billed, s1);
            SallesRecords r18 = new SallesRecords(18, new DateTime(2018, 10, 24), 6000.0, SalesStatus.Billed, s3);
            SallesRecords r19 = new SallesRecords(19, new DateTime(2018, 10, 22), 8000.0, SalesStatus.Billed, s5);
            SallesRecords r20 = new SallesRecords(20, new DateTime(2018, 10, 15), 8000.0, SalesStatus.Billed, s6);
            SallesRecords r21 = new SallesRecords(21, new DateTime(2018, 10, 17), 9000.0, SalesStatus.Billed, s2);
            SallesRecords r22 = new SallesRecords(22, new DateTime(2018, 10, 24), 4000.0, SalesStatus.Billed, s4);
            SallesRecords r23 = new SallesRecords(23, new DateTime(2018, 10, 19), 11000.0, SalesStatus.Canceled, s2);
            SallesRecords r24 = new SallesRecords(24, new DateTime(2018, 10, 12), 8000.0, SalesStatus.Billed, s5);
            SallesRecords r25 = new SallesRecords(25, new DateTime(2018, 10, 31), 7000.0, SalesStatus.Billed, s3);
            SallesRecords r26 = new SallesRecords(26, new DateTime(2018, 10, 6), 5000.0, SalesStatus.Billed, s4);
            SallesRecords r27 = new SallesRecords(27, new DateTime(2018, 10, 13), 9000.0, SalesStatus.Pending, s1);
            SallesRecords r28 = new SallesRecords(28, new DateTime(2018, 10, 7), 4000.0, SalesStatus.Billed, s3);
            SallesRecords r29 = new SallesRecords(29, new DateTime(2018, 10, 23), 12000.0, SalesStatus.Billed, s5);
            SallesRecords r30 = new SallesRecords(30, new DateTime(2018, 10, 12), 5000.0, SalesStatus.Billed, s2);

            _context.Departament.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );
            _context.SaveChanges();
        }
    }
}
