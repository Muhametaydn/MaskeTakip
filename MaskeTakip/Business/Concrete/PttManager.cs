﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
        string _ad;
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //contructer
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            

            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");

            }
        }
    }
}