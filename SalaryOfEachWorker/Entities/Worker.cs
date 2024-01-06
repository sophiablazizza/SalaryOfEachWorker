using SalaryOfEachWorker.Entities.Enums;

namespace SalaryOfEachWorker.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

    }
}
