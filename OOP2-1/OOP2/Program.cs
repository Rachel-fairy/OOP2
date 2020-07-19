using System;

//命名空间 名字空间 Java里的package
namespace OOP2  //粗略理解为写 类
{
    class Program
    {
        //入口点 Entry
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");  //printf();
        }

        void tellstory()
        {
            Student xiaoming = new Student();
            xiaoming.Birth();
            xiaoming.Name = "xiaoming";
            xiaoming.Earn(1000);

            Student xiahong = new Student();
            xiaoming.Birth();
            xiaoming.Name = "xiaoming";
            xiaoming.Earn(1200);
            Canteen1 Cafe1= new Canteen1();

            xiaoming.walk(10);

            while (xiaoming.IsHunrgy()&&!xiaoming.IsDead())
            {
                int Food = Cafe1.Charge(10);
                if (Food>0)
                {
                    xiaoming.Pay(10);
                    xiaoming.Eat(Food);
                }
                else
                {
                    Cafe1.SupplyFood();
                }
            }

        }
    }

    //抽离概念（v.抽象）

    class People
    {
        //成员变量
        //成员方法
        //Console.WriteLine();    //printf;

        //People xiaoming = new People();
        //People xiaohonog = new People();
        public int Age;
        public int healthpoints;
        public String Name;
        bool Gender;

        public void Birth()
        {
            Age -= 0;
            healthpoints = 100;
            Gender = DateTime.Now.Second % 2 == 0;
        }
        public void Death()
        {
            healthpoints = 0;
        }
        public bool IsDead()
        {
            return healthpoints < 0;
        }
        public bool IsHunrgy() 
        {
            return healthpoints < 60;
        }
        public string Say(string words)
        {
            if (words=="饿不饿")
            {
                if (healthpoints < 60)
                {
                    return "饿了";
                }
                else
                    return "不饿";
            }
            return words;
            
        }
        public void walk(int speed) 
        {
            if (speed<10)
            {
                healthpoints -= speed * 1;
            }
            else if(speed<20)
            {
                healthpoints -= speed * 2;
            }
        }
        public void Eat(int appetite)
        {
            healthpoints += appetite * 3;
        }

    }

    class Student : People
    {        
        int money ;

        public void Earn(int count) 
        {
            money += count;
        }
        public void Pay(int count)
        {
            money -=count;
        }
    }

    class Canteen1
    {
        int TotalFood;
        int Income;
        public int Charge(int cost)
        {

            int Food = cost * 4;
            if (Food > TotalFood)
            {
                return 0;
            }
            else
            {
                Income += cost;
                return Food;
            }
        }
        public void SupplyFood()
        {
            TotalFood += 100;
        }
    }

    class Canteen2
    {

        int TotalFood;
        int Income;
        int Charge(int cost)
        {
            Income += cost;
            int Food = cost * 3;
            return Food;
        }
        void SupplyFood()
        {
            TotalFood += 160;
        }
    }


}
