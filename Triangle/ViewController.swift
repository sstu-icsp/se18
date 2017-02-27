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
//  Notes:       1. The "user instructions" code works well, but isn't clear.
//               2. No MVC
//  WARNING!
//  THIS VERSION IS TWEAKED SO MORE UNIT TESTS CAN BE PERFORMED. 
//  THE ADDED CODE IS ABSOLUTELY TERRIBLE.

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
        if convertsToDouble(text: userInputTextField.text) {
            let value = Double(userInputTextField.text!)!
            
            if has(less: points, than: 6) {
                points.append(value)
                userInputTextField.text = nil
            }
            
            if has(6, points) {
                var alert = UIAlertController()
                
                if calculateAreaOfTriangle(withPoints: points).0! != 0 {
                    alert = makeAnAlert(
                        withTitle: String(abs(calculateAreaOfTriangle(withPoints: points).0!)), saying: "is the area of the triangle."
                    )
                } else {
                    alert = makeAnAlert(
                        withTitle: "Error", saying: "Presented points don't form a triangle."
                    )
                }
                
                alert.addAction(UIAlertAction(title: "Dismiss", style: UIAlertActionStyle.default, handler: nil))
                self.present(alert, animated: true, completion: nil)
                
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
    
    func calculateAreaOfTriangle(withPoints points: [Double]) -> (Double?, String?) {
        if has(6, points) {
            let result = 0.5 * ((points[0] - points[4]) * (points[3] - points[1]) - (points[0] - points[2]) * (points[5] - points[1]))
            return (abs(result), nil)
        } else {
            return (nil, "The number of points is incorrect.")
        }
    }
    
    // Bloat methods for testing
    func convertsToDouble(text: String?) -> Bool {
        if let _ = Double(text!) {
            return true
        } else {
            return false
        }
    }
    
    func has(_ count: Int, _ points: [Double]) -> Bool {
        if points.count == count {
            return true
        } else {
            return false
        }
    }
    
    func has(less points: [Double], than count: Int) -> Bool {
        if points.count < count {
            return true
        } else {
            return false
        }
    }
    
    func makeAnAlert(withTitle title: String, saying message: String) -> UIAlertController {
        return UIAlertController(title: title, message: message, preferredStyle: UIAlertControllerStyle.alert)
    }
}
