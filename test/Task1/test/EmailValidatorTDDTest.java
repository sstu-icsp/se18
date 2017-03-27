/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Task1.test;
import Task1.classes.EmailValidatorTDD;
import java.util.ArrayList;
import java.util.List;
import org.junit.Test;
import static org.junit.Assert.*;
/**
 *
 * @author dbocharov
 */
public class EmailValidatorTDDTest 
{
    private final char[] TEXT=new char[151];
    
    @Test
    public void testLengthAddress()
    {
        EmailValidatorTDD emailValidatorTDD=new EmailValidatorTDD(new String(TEXT));
        assertEquals("false", emailValidatorTDD.validate());
    }
    
    @Test
    public void testLevelDomain()
    {
        EmailValidatorTDD emailValidatorTDD=new EmailValidatorTDD("address@www.neoflex.ru");
        assertEquals("false", emailValidatorTDD.validate());
    }
    
    @Test
    public void testLengthDomain()
    {
        EmailValidatorTDD emailValidatorTDD=new EmailValidatorTDD("address@"+new String(TEXT));
        assertEquals("false", emailValidatorTDD.validate());
    }
    @Test
    public void checkBlackSender()
    {
        EmailValidatorTDD emailValidatorTDD=new EmailValidatorTDD("sender@domain.ru");
        List<String> senders=new ArrayList<>();
        senders.add("sender");
        assertEquals("danger", emailValidatorTDD.validate(senders));
    }
    @Test
    public void checkBlackDomain()
    {
        EmailValidatorTDD emailValidatorTDD=new EmailValidatorTDD("sender@domain.ru");
        List<String>senders=new ArrayList<>();
        List<String>domains=new ArrayList<>();
        domains.add("domain.ru");
        assertEquals("danger", emailValidatorTDD.validate(senders,domains));
    }
}
