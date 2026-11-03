using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using UsingBinding.Models;

namespace UsingBinding.ViewModels
{
    public class MuscleListViewModel : ViewModelBase
    {
        public ObservableCollection<Muscle> Muscles { get; set; }

        private Muscle? selectedMuscle;

        public Muscle? SelectedMuscle
        {
            get { return selectedMuscle; }
            set
            {
                if (selectedMuscle != value)
                {
                    selectedMuscle = value;
                    OnPropertyChanged();
                }
            }
        }

        public Command AddMuscleCommand { get; }
        public Command DeleteMuscleCommand { get; }
        public Command ClearSelectionCommand { get; }

        public MuscleListViewModel()
        {
            Muscles = new ObservableCollection<Muscle>
            {
                new Muscle
                {
                    Name = "Biceps",
                    BodyPart = "Arms"
                },

                new Muscle
                {
                    Name = "Triceps",
                    BodyPart = "Arms"
                },

                new Muscle
                {
                    Name = "Pectorals",
                    BodyPart = "Chest"
                },

                new Muscle
                {
                    Name = "Quadriceps",
                    BodyPart = "Legs"
                },

                new Muscle
                {
                    Name = "Latissimus Dorsi",
                    BodyPart = "Back"
                }
            };

            AddMuscleCommand = new Command(AddMuscle);
            DeleteMuscleCommand = new Command(DeleteMuscle);
            ClearSelectionCommand = new Command(ClearSelection);
        }

        private void AddMuscle()
        {
            Muscle newMuscle = new Muscle
            {
                Name = "New Muscle",
                BodyPart = "Unknown"
            };

            Muscles.Add(newMuscle);

            SelectedMuscle = newMuscle;
        }

        private void DeleteMuscle()
        {
            if (SelectedMuscle == null)
            {
                return;
            }

            Muscles.Remove(SelectedMuscle);

            SelectedMuscle = null;
        }

        private void ClearSelection()
        {
            SelectedMuscle = null;
        }
    }
}