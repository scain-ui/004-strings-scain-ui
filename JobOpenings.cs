using System.Security.Cryptography.X509Certificates;

namespace knightmoves;
public class JobOpenings
{   
    public string FirstName = "Samuel";

    public string JobTitle = "Animal Behavior Specialist";

    public string City = "Seward";

    public string PrintOpening(){
    
        return $@"{FirstName}, {JobTitle}, {City}, and a new line";
    }
}
