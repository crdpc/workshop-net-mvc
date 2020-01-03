using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // O banco de dados já foi populacionado
            }

            Departments d1 = new Departments(1, "Computer");
            Departments d2 = new Departments(2, "Eletronics");
            Departments d3 = new Departments(3, "Fashion");
            Departments d4 = new Departments(4, "Books");

            Seller s1 = new Seller(1, "Carlos Domingues", "crdpc@yahoo.com.br", new DateTime(1970, 9, 8), 1300.0, d1);
            Seller s2 = new Seller(2, "Jacqueline Domingues", "Jacuqueline@yahoo.com.br", new DateTime(1970, 9, 8), 1300.0, d3);
            Seller s3 = new Seller(3, "Ana Beatriz Domingues", "ana@yahoo.com.br", new DateTime(2009, 8, 8), 1000.0, d2);
            Seller s4 = new Seller(4, "Nathalia Hans Domingues", "nathalia.hans@yahoo.com.br", new DateTime(1970, 11, 25), 1300.0, d4);
            Seller s5 = new Seller(5, "João Batista", "jbatista@yahoo.com.br", new DateTime(1970, 5, 15), 1300.0, d3);
            Seller s6 = new Seller(6, "Aline Souza", "aline,souza@yahoo.com.br", new DateTime(1970, 7, 14), 1300.0, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 11, 25), 10000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 09, 10), 10000.0, SaleStatus.Billed, s3);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 01, 15), 10000.0, SaleStatus.Billed, s5);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 05, 30), 20000.0, SaleStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 10, 31), 30000.0, SaleStatus.Billed, s4);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 01, 07),  5000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 12, 12), 10000.0, SaleStatus.Billed, s6);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 08, 24), 60000.0, SaleStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 03, 10), 40000.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 05, 24), 50000.0, SaleStatus.Billed, s5);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 10, 14), 15000.0, SaleStatus.Billed, s4);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 09, 15), 10000.0, SaleStatus.Billed, s6);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 09, 16), 130000.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 03, 17), 10000.0, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 06, 18), 160000.0, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 11, 19), 180000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 03, 20), 130000.0, SaleStatus.Billed, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 07, 21), 190000.0, SaleStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 07, 22), 110000.0, SaleStatus.Billed, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2019, 01, 23), 70000.0, SaleStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2019, 03, 24), 80000.0, SaleStatus.Billed, s3);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2019, 09, 25), 12000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2019, 08, 26), 40000.0, SaleStatus.Billed, s6);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2019, 07, 27), 60000.0, SaleStatus.Billed, s3);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2019, 06, 28), 40000.0, SaleStatus.Billed, s6);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2019, 04, 29), 80000.0, SaleStatus.Billed, s5);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2019, 03, 30), 90000.0, SaleStatus.Billed, s4);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2019, 02, 22), 1000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2019, 01, 06), 60000.0, SaleStatus.Billed, s2);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2019, 12, 10), 30000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
