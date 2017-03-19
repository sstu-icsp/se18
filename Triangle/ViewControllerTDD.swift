//
//  ViewController.swift
//  Triangle-TDD
//
//  Created by Constantine Shatalov on 7/8/17.
//  Copyright © 2017 New Route. All rights reserved.
//

import UIKit

class ViewControllerTDD: UIViewController {
    
    override func viewDidLoad() {
        super.viewDidLoad()
    }
    
    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    
    // Store coordinates entered by user
    var points = [Double]()
    
    // UI
    @IBOutlet weak var userInstructionsLabel: UILabel!
    @IBOutlet weak var textField: UITextField!
    
    @IBAction func doneButton(_ sender: UIButton) {
        if convertsToDouble(text: textField.text) {
            let coordinate = Double(textField.text!)!
            
            if has(less: points, than: 6) {
                points.append(coordinate)
                textField.text = nil
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
            }
        } else {
            textField.text = nil
            
            let alertMessage = UIAlertController(
                title: "Error",
                message: "The coordinate you entered is not valid.",
                preferredStyle: UIAlertControllerStyle.alert
            )
            
            alertMessage.addAction(UIAlertAction(title: "Dismiss", style: UIAlertActionStyle.default, handler: nil))
            self.present(alertMessage, animated: true, completion: nil)
        }
    }
    
    func calculateAreaOfTriangle(withPoints points: [Double]) -> (Double?, String?) {
        if has(6, points) {
            let result = 0.5 * ((points[0] - points[4]) * (points[3] - points[1]) - (points[0] - points[2]) * (points[5] - points[1]))
            return (abs(result), nil)
        } else {
            return (nil, "The number of points is incorrect.")
        }
    }
    
    // Implement methods from tests
    func convertsToDouble(text: String?) -> Bool {
        return Double(text!) != nil ? true : false
    }
    
    func has(_ count: Int, _ points: [Double]) -> Bool {
        return points.count == count ? true : false
    }
    
    func has(less points: [Double], than count: Int) -> Bool {
        return points.count < count ? true : false
    }
    
    func makeAnAlert(withTitle title: String, saying message: String) -> UIAlertController {
        return UIAlertController(title: title, message: message, preferredStyle: UIAlertControllerStyle.alert)
    }
}
