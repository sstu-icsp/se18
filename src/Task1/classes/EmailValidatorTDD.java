/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Task1.classes;

import java.util.List;

/**
 *
 * @author dbocharov
 */
public class EmailValidatorTDD 
{
  private String address;

    public EmailValidatorTDD(String address) {
        this.address = address;
    }
    public String validate()
    {
        if(address.length()>150) return "false";
        
        String domain=address.split("@")[1];
        if(domain.split("[.]").length>2) return "false";
        
        if (domain.length()>50) return "false";
        
        
        
        return "true";
    }
    public String validate(List<String> senders)
    {
        String result=validate();
        String sender=address.split("@")[0];
        if(senders.contains(sender)) result="danger";
        return result;
    }

    public String validate(List<String> senders, List<String> domains) 
    {
        String result=validate(senders);
        String domain=address.split("@")[1];
        if(domains.contains(domain))result="danger";
        return result;
    }
           
}
