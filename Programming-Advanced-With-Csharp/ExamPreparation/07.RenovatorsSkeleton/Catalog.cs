using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;

        private string name;

        private int neededRenovators;

        private string project;

        public Catalog(string name, int neededRenovators, string project)
        {
            renovators = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public string Name { get; set; }

        public int NeededRenovators { get; set; }

        public string Project { get; set; }

        public int Count => renovators.Count;

        public IReadOnlyCollection<Renovator> Renovators => this.renovators;

        public string AddRenovator(Renovator renovator)
        {
            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }

            if (Count > NeededRenovators)
            {
                return "Renovators are no more needed.";
            }

            if (renovator.Rate > 350)
            {
                return "Invalid renovator's rate.";
            }


            renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            var targetRenovator = renovators.FirstOrDefault(x => x.Name == name);
            if (renovators.Contains(targetRenovator))
            {
                renovators.Remove(targetRenovator);
                return true;
            }

            return false;
        }

       public int RemoveRenovatorBySpecialty(string type)
        {
            return renovators.RemoveAll(x => x.Type == type);
        }

        public  Renovator HireRenovator(string name)
        {
            var targetRenovator = renovators.FirstOrDefault(r => r.Name == name); ;
            if (renovators.Contains(targetRenovator))
            {
                targetRenovator.Hired = true;
                return targetRenovator;
            }
            
            return null;
        }

        public List<Renovator> PayRenovators(int days)
        {
             var workedRenovators = renovators.FindAll(r => r.Days > 0);
             return workedRenovators;
        }


        public string Report()
        {
            var hiredRenovators = renovators.FindAll(r => r.Hired == true);
          
            return $"Renovators available for Project {project}:" + string.Join(Environment.NewLine, hiredRenovators);
        }
    }
}