//
//  ViewController.swift
//  Triangle
//
//  Created by Constantine Shatalov on 2/26/17.
//  Copyright © 2017 New Route. All rights reserved.
//

//  #01
//  iOS Applications Testing (Unit Testing)
//  Description: The program calculates the area of a triangle, given 3 points.
//               The points are entered by a user as follows: Ax, Ay, Bx, By, Cx, Cy.
//  Notes:       The "user instructions" code works well, but isn't clear.

import UIKit

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        
        userInstructionsLabel.text = "Enter the " + instructions[0]
        userInputTextField.keyboardType = UIKeyboardType.numbersAndPunctuation
        userInputTextField.keyboardAppearance = UIKeyboardAppearance.dark
        userInputTextField.autocorrectionType = UITextAutocorrectionType.no
        userInputTextField.returnKeyType = UIReturnKeyType.next
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
    }
    
    // UI
    @IBOutlet weak var userInstructionsLabel: UILabel!
    @IBOutlet weak var userInputTextField: UITextField!
    
    // Store points here
    var points = [Double]()
    
    // Store instructions here
    var instructions = [
        "X coordinate of A", "Y coordinate of A", "X coordinate of B", "Y coordinate of B", "X coordinate of C", "Y coordinate of C"
    ]
    
    @IBAction func sendIt(_ sender: UIButton) {
        if let value = Double(userInputTextField.text!) {
            if points.count < 6 {
                points.append(value)
                userInputTextField.text = nil
            }
            
            if points.count == 6 {
                var alertMessage = UIAlertController()
                
                if calculateAreaOfTriangle(withPoints: points) != 0 {
                    alertMessage = UIAlertController(
                        title: String(abs(calculateAreaOfTriangle(withPoints: points))),
                        message: "is the area of the triangle.",
                        preferredStyle: UIAlertControllerStyle.alert
                    )
                } else {
                    alertMessage = UIAlertController(
                        title: "Error",
                        message: "Presented points don't form a triangle.",
                        preferredStyle: UIAlertControllerStyle.alert
                    )
                }
                
                alertMessage.addAction(UIAlertAction(title: "Dismiss", style: UIAlertActionStyle.default, handler: nil))
                self.present(alertMessage, animated: true, completion: nil)
                
                points.removeAll()
                userInstructionsLabel.text = "Enter the X coordinate of A"
            }
        } else {
            userInputTextField.text = nil
            
            let alertMessage = UIAlertController(
                title: "Error",
                message: "The coordinate you entered is not valid.",
                preferredStyle: UIAlertControllerStyle.alert
            )
            
            alertMessage.addAction(UIAlertAction(title: "Dismiss", style: UIAlertActionStyle.default, handler: nil))
            self.present(alertMessage, animated: true, completion: nil)
        }
        
        userInstructionsLabel.text = "Enter the " + instructions[points.count]  // Careful here
    }
    
    func calculateAreaOfTriangle(withPoints points: [Double]) -> Double {
        let result = 0.5 * ((points[0] - points[4]) * (points[3] - points[1]) - (points[0] - points[2]) * (points[5] - points[1]))
        
        return abs(result)
    }
}
