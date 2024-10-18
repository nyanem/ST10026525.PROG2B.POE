namespace ST10026525.PROG62112.POE.part1.Models
{
    public class Claims
    {
        public int ClaimsId { get; set; }
        public int LecturerId {  get; set; }

        public DateTime claimDate { get; set; }

        public int hoursWorked { get; set; }
  
        public int hourlyRate { get; set; }
    
        public decimal TotalAmount { get; set; }
        public string Status    { get; set; }
 
        public string supportingDocument { get; internal set; }

 
    }
}
