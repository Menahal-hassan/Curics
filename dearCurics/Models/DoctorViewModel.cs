using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dearCurics.Models
{
    public class DoctorViewModel
    {
        private int id;
        private string name;
        private string gender;
        private string address;
        private string email;
        private string contact_number;
        private string degree;
        private string specialization;
        private string facebook_id;
        private string twitter_id;
        private string instegram_id;
        private string image_source;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Contact_number { get => contact_number; set => contact_number = value; }
        public string Degree { get => degree; set => degree = value; }
        public string Specialization { get => specialization; set => specialization = value; }
        public string Facebook_id { get => facebook_id; set => facebook_id = value; }
        public string Twitter_id { get => twitter_id; set => twitter_id = value; }
        public string Instegram_id { get => instegram_id; set => instegram_id = value; }
        public string Image_source { get => image_source; set => image_source = value; }

        public static List<doctor_work_experience> Experience_list(int a )
        {
            CuricsEntities entity = new CuricsEntities();
            var list = entity.doctor_work_experience.ToList();

            List<doctor_work_experience>  work_list = new List<doctor_work_experience>();
            foreach(doctor_work_experience item in list)
            {
                if (item.doctor_id==a)
                {
                    work_list.Add(item);
                }

            }
            return (work_list);
        }
        public static List<doctor_price_payment> Price_list(int a)
        {
            CuricsEntities entity = new CuricsEntities();
            var list = entity.doctor_price_payment.ToList();

            List<doctor_price_payment> payment_list = new List<doctor_price_payment>();
            foreach (doctor_price_payment item in list)
            {
                if (item.doctor_id == a)
                {
                    payment_list.Add(item);
                }

            }
            return (payment_list);
        }
    }
}