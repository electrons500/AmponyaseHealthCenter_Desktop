namespace AmponyaseHealthCenter_Desktop
{
    // This class is used to retrieve staff number from dashboard to any form.
    class  StaffNumberRetrival
    {
        private static int Num;

        public StaffNumberRetrival(int _num)
        {
            Num = _num;
        }

        public static void SetStaffNumber(int a)
        {
            Num = a;
        }

        public static int GetStaffNumber()
        {
            return Num;
        }

    }
}
