using LessonMVVM.Services;
using Library_Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus_Models.Entities.Concrete
{
    public class StudentDTO  : NotificationService
    {
        public int Id { get; set; }
        private string? FirstName { get; set; }
        private string? LastName { get; set; }
        private string? HomeAddress { get; set; }
        private string? OtherAddress { get; set; }

        //Foreign Key
        private int ClassId { get; set; }
        private int RideId { get; set; }
        private int ParentId { get; set; }

        //Navigation Property
        private Parent? Parent { get; set; }
        private Class? Class { get; set; }
        private Ride? Ride { get; set; }

        public string? firstName
        {
            get => FirstName;
            set
            {
                FirstName = value;
                OnPropertyChanged();
            }
        }

        public string? lastName
        {
            get => LastName;
            set
            {
                LastName = value;
                OnPropertyChanged();
            }
        }

        public int classId
        {
            get => ClassId;
            set
            {
                ClassId = value;
                OnPropertyChanged();
            }
        }

        public int rideId
        {
            get => RideId;
            set
            {
                RideId = value;
                OnPropertyChanged();
            }
        }

        public int parentId
        {
            get => ParentId;
            set
            {
                ParentId = value;
                OnPropertyChanged();
            }
        }

        public Parent? parent
        {
            get => Parent;
            set
            {
                Parent = value;
                OnPropertyChanged();
            }
        }

        public Class? classs
        {
            get => Class;
            set
            {
                Class = value;
                OnPropertyChanged();
            }
        }

        public Ride? ride
        {
            get => Ride;
            set
            {
                Ride = value;
                OnPropertyChanged();
            }
        }
    }
}
