/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Task1.test;

import Task1.classes.EmailValidatorUnit;
import java.util.ArrayList;
import java.util.List;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author dbocharov
 */
public class EmailValidatorUnitTest {
    private final String TEST_SENDER="sender";
    private final String TEST_DOMAIN="domain.ru";
    final char[] TEST=new char[151];
    public EmailValidatorUnitTest() {
    }
    @Test
    public void testLengthAdress() 
    {
    EmailValidatorUnit emailValidator=new EmailValidatorUnit(TEST_SENDER+"@"+new String(TEST));
    assertEquals("false", emailValidator.validate(new ArrayList<>(), new ArrayList<>()));
    }
    @Test
    public void testLevelDomain()
    {
        EmailValidatorUnit emailValidator=new EmailValidatorUnit("address@www.neoflex.ru");
        assertEquals("false", emailValidator.validate(new ArrayList<>(), new ArrayList<>()) );
    }
    @Test
    public void testLengthDomain()
    {
        EmailValidatorUnit emailValidator=new EmailValidatorUnit(TEST_SENDER+"@"+new String(TEST));
        assertEquals("false", emailValidator.validate(new ArrayList<>(), new ArrayList<>()));
    }
    @Test
    public void testCheckSender()
    {
        List <String> senders=new ArrayList<>();
        senders.add(TEST_SENDER);
        EmailValidatorUnit emailValidator=new EmailValidatorUnit(TEST_SENDER+"@"+TEST_DOMAIN);
        assertEquals("danger", emailValidator.validate(senders, new ArrayList<>()));
    }
    @Test
    public void testCheckDomain()
    {
        List<String> domains=new ArrayList<>();
        domains.add(TEST_DOMAIN);
        EmailValidatorUnit emailValidator=new EmailValidatorUnit(TEST_SENDER+"@"+TEST_DOMAIN);
        assertEquals("danger", emailValidator.validate(new ArrayList<>(), domains));
    }
}
