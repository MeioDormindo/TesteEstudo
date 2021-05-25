using System;
using Composition01.Entities.Enums;
using System.Collections.Generic;

namespace Composition01.Entities
{
    class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }

        public Double BaseSalary { get; set; }

        public Department Department { get; set; }

        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HoursContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HoursContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach  (HoursContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
