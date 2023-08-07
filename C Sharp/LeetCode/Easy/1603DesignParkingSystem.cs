namespace LeetCode.Easy
{
    /*
     * 1603. Design Parking System
     * Design a parking system for a parking lot. The parking lot has three kinds of parking spaces:
     * big, medium, and small, with a fixed number of slots for each size.
     * Implement the ParkingSystem class:
     * ParkingSystem(int big, int medium, int small) Initializes object of the ParkingSystem class.
     * The number of slots for each parking space are given as part of the constructor.
     * bool addCar(int carType) Checks whether there is a parking space of carType for the car that wants to get into the parking lot.
     * carType can be of three kinds: big, medium, or small, which are represented by 1, 2, and 3 respectively.
     * A car can only park in a parking space of its carType.
     * If there is no space available, return false, else park the car in that size space and return true.
     */
    internal class _1603DesignParkingSystem
    {

    }
    public class ParkingSystem
    {
        private int[] _slots = new int[3];
        private int[] _busySlots = new int[3];
        public ParkingSystem(int big, int medium, int small)
        {
            _slots[0] = big;
            _slots[1] = medium;
            _slots[2] = small;
        }

        public bool AddCar(int carType)
        {
            int slot = carType - 1;
            if (_busySlots[slot] < _slots[slot])
            {
                _busySlots[slot]++;
                return true;
            }
            return false;
        }
    }
}
