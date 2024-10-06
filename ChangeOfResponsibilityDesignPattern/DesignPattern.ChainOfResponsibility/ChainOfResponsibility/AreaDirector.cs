using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class AreaDirector : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 400000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme işlemi onaylandı.Müşteriye talep ettiği tutar ödendi";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.Name = request.Name;
                customerProcess.EmployeeName = "Bölge Müdürü - Zeynep Yılmaz";
                customerProcess.Description = "Para çekme işlemi tutarı Bölge Müdürünün  günlük ödeyebileceği limiti aştığı için işlem gerçekleştirilemedi.Müşterinin günlük maksimum çekebileceği tutar 400.000TL olup daha fazlası için birden fazla gün şubeye gelmesi gerekli ";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
        }
    }
}
