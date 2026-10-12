using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5Demo
{
    internal abstract class Beverage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        protected float servingTemperature;
        public Beverage()
        {

        }
        public Beverage(int id)
        {
            Id = id;
        }
        public Beverage(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public virtual void SetBasetemp()
        {
            this.servingTemperature = 40;
        }
        public abstract double CalculatePrice();
    }

    class Coffee : Beverage
    {
        public string Bean { get; set; }
        public string Size { get; set; }
       
        public string Type { get; set; }
        public override void SetBasetemp()
        {
            this.servingTemperature = 50;
        }

        public sealed override double CalculatePrice()
        {
            throw new NotImplementedException();
        }
        public Coffee()
        {

        }
        public Coffee(int id,string bean,string type):base(id)
        {
            this.Bean = bean;
            this.Type = type;
        }
        public Coffee(int id,string name,string bean,string type):base(id,name)
        {
            this.Bean = bean;
            this.Type = type;
        }
        public float ServingTempeture
        {
            get { return this.servingTemperature; }
        }
    }

    //last class in hierarchy
     sealed class Espresso:Coffee
    {
        public int Shots { get; set; }
        public Espresso()
        {

        }
        public Espresso(int id,string name,string type):base(id,name,type)
        {

        }
      
        public  override void SetBasetemp()
        {
            base.SetBasetemp();
        }
    }
}
