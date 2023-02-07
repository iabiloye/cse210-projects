using System;


public class Scripture
{
    private string _phase;



    public Scripture(){
        //Default values
        _phase = "Unknown";
    }

    
    public Scripture(string phaseToInput)
    {
        
       
        _phase = phaseToInput;
    }
    
    public string GetPhase(){
       
        return _phase;
    }
    public void SetPhase(string phaseToSet){
        _phase = phaseToSet; 
    }
       public string GetCompleteScripture()
    {
        //Assign the value
        string phaseToReturn = _phase;
        //Assign the value
        return phaseToReturn;

    }
        
   
}