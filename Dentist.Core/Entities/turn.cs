﻿using Dentist;
using Dentist.Core.Entities;

namespace dentist
{
    public class turn
    {
        public int Id { get; set; }
        public string IdPatient { get; set; }
        public string IdDoctor { get; set; }
        public Doctors doctor { get; set; }
        public Patient patint { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
    }
}
