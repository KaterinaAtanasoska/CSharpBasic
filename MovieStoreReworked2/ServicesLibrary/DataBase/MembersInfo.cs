using ProjectLibrary.Enum;
using ProjectLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLibrary
{
    public class MembersInfo
    {

        public static Member[] Members = new Member[]
        {
            new Employee("Lauren", "Ridens", 42, "LaurenR", "123", 777999, new DateTime(2010, 2, 10), 40),
            new Employee("Jed", "Crout", 30, "jed", "456", 666555, new DateTime (2015, 6, 22), 36),
            new User("Charolotte", "Khogel", 25, "khogel", "789", 111222, new DateTime (2018, 8, 13), 1, ProjectLibrary.Enum.Subscription.Annually, new Movie[] { MoviesInfo.Movies[3], MoviesInfo.Movies[1] }),
            new User("Adam", "Ronsai", 29, "adam", "123", 333555, new DateTime (2020, 2, 6), 2, ProjectLibrary.Enum.Subscription.Monthly, new Movie[] { MoviesInfo.Movies[5], MoviesInfo.Movies[7]})
        };

        public static Member MemberLogged = new Member();

        public static Employee EmployeeLogged = new Employee();

        public static User UserLogged = new User();

        public static void PrintMembers()
        {
            foreach (Member member in Members)
            {
                member.DisplayInfo();
            }
        }

        public static void DeleteMember()
        {
            Console.WriteLine("Enter username of memer:");
            string username = Console.ReadLine();
            //bool incorrectInputUsername = false;
            foreach (var member in MembersInfo.Members)
            {
                if (member.UserName == username)
                {
                    List<Member> memberList = new List<Member>(MembersInfo.Members);
                    Console.WriteLine($"{username} is deleted");
                    memberList.Remove(member);
                    MembersInfo.Members = memberList.ToArray();                    
                }
                //else
                //{
                //    incorrectInputUsername = true;
                //}
             
            }
            //if (incorrectInputUsername == true)
            //{
            //    Console.WriteLine($"No member to show with {username}");
            //}
        }

        public static void subsExpirationt()
        {
            int days;

            if (MembersInfo.UserLogged.TypeOfSubscription == Subscription.Monthly)
            {
                days = ((MembersInfo.UserLogged.DateOfRegistration) - DateTime.Now).Days + 30;

                if (days < 0)
                {
                    Console.WriteLine($"Subscription type: {MembersInfo.UserLogged.TypeOfSubscription} | Expired subscription!");
                }
                else
                {
                    Console.WriteLine($"Subscription type: {MembersInfo.UserLogged.TypeOfSubscription} | Subscription time left: {days} days");
                }
            }
            else if (MembersInfo.UserLogged.TypeOfSubscription == Subscription.Annually)
            {
                days = ((MembersInfo.UserLogged.DateOfRegistration) - DateTime.Now).Days + 365;

                if (days < 0)
                {
                    Console.WriteLine($"Subscription type: {MembersInfo.UserLogged.TypeOfSubscription} | Expired subscription!");
                }
                else
                {
                    Console.WriteLine($"Subscription type: {MembersInfo.UserLogged.TypeOfSubscription} | Subscription time left: {days} days");
                }
            }
        }


        public static void RentedMovies()
        {
            foreach (var movie in MembersInfo.UserLogged.Movies)
            {
                Console.WriteLine(movie.Title);
            }
        }
        
    }
}
