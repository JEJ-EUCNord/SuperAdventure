using System.ComponentModel;

namespace Engine
{
    public class LivingCreature : Stats, INotifyPropertyChanged
    {
        private int _currentHitPoints;

        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            set
            {
                _currentHitPoints = value;
                OnPropertyChanged("CurrentHitPoints");
            }
        }

        public int MaximumHitPoints { get; set; }

        public bool IsDead { get { return CurrentHitPoints <= 0; } }


        public LivingCreature(int maximumHitPoints, int currentHitPoints, int strength,int intellect, int agility, int defense, int criticalStrike) : base(strength, intellect, agility, defense, criticalStrike)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
