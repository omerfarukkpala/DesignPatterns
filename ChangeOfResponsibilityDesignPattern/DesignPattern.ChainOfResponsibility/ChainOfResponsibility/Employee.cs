using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;

        public void SetNextApprover(Employee superVisor)
        {
            this.NextApprover = superVisor; // Sıradaki onaylayıcım diger calısandan gelen deger olacak.
        }

        public abstract void ProcessRequest(CustomerProcessViewModel request);
        
    }
}
