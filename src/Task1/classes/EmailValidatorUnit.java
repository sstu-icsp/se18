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
public class EmailValidatorUnit 
{
 private final String sender;
 private final String domain;

public EmailValidatorUnit(String address) 
{
    String[] temp=address.split("@");
    sender=temp[0];
    domain=temp[1];    
}
public String validate(List<String> senders, List<String> domains)
{
    if((sender+"@"+domain).length()>150)return "false";
    if(domain.split("[.]").length>2)return "false";
    if(domain.length()>50)return "false";
    if(senders.contains(sender)||domains.contains(domain)) return "danger";
    return "true";
}
}
