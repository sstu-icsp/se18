//
//  ViewControllerTests.swift
//  Triangle
//
//  Created by Constantine Shatalov on 2/27/17.
//  Copyright © 2017 New Route. All rights reserved.
//

import XCTest
@testable import Triangle

class ViewControllerTests: XCTestCase {
    
    override func setUp() {
        super.setUp()
        // Put setup code here. This method is called before the invocation of each test method in the class.
    }
    
    override func tearDown() {
        // Put teardown code here. This method is called after the invocation of each test method in the class.
        super.tearDown()
    }
    
    func testPerformanceExample() {
        // This is an example of a performance test case.
        self.measure {
            // Put the code you want to measure the time of here.
        }
    }
    
    let viewController = ViewController()
    
    // 1 - func has(_ count: Int, _ points: [Double]) -> Bool
    func testHasExpectTrue() {
        XCTAssertTrue(viewController.has(2, [0.0, 0.0]))
    }
    
    func testHasExpectFalse() {
        XCTAssertFalse(viewController.has(3, [0.0, 0.0]))
    }
    
    // 2 - func has(less points: [Double], than count: Int) -> Bool
    func testHasLessExpectTrue() {
        XCTAssertTrue(viewController.has(less: [0.0, 0.0], than: 3))
    }
    
    func testHasLessExpectFalse() {
        XCTAssertFalse(viewController.has(less: [0.0, 0.0], than: 1))
    }
    
    // 3 - func convertsToDouble(text: String?) -> Bool
    func testConvertsToDoubleExpectTrue() {
        XCTAssertTrue(viewController.convertsToDouble(text: "0.0"))
    }
    
    func testConvertsToDoubleExpectFalse() {
        XCTAssertFalse(viewController.convertsToDouble(text: "%$a"))
    }
    
    // 4 - func calculateAreaOfTriangle(withPoints points: [Double]) -> (Double?, String?)
    func testCalculateAreaOfTriangleExpectTrue() {
        XCTAssertEqual(viewController.calculateAreaOfTriangle(withPoints: [1.0, 0.0, 1.0, 5.0, 2.0, 0.0]).0!, 2.5)
    }
    
    func testCalculateAreaOfTriangleExpectFalse() {
        XCTAssertNotEqual(viewController.calculateAreaOfTriangle(withPoints: [1.0, 0.0, 1.2, 5.0, 3.0, 0.0]).0!, 2.5)
    }
    
    func testCalculateAreaOfTriangleExpectNilFromString() {
        XCTAssertNil(viewController.calculateAreaOfTriangle(withPoints: [1.0, 0.0, 1.2, 5.0, 3.0, 0.0]).1)
    }
    
    func testCalculateAreaOfTriangleExpectNilFromDouble() {
        XCTAssertNil(viewController.calculateAreaOfTriangle(withPoints: [1.0, 0.0, 1.0, 5.0, 2.0]).0)
    }
    
    func testCalculateAreaOfTriangleExpectStringMessage() {
        XCTAssertEqual(viewController.calculateAreaOfTriangle(withPoints: [1.0, 0.0, 1.0, 5.0, 2.0]).1!, "The number of points is incorrect.")
    }
    
    // 5 - func makeAnAlert(withTitle title: String, saying message: String) -> UIAlertController
    func testMakeAnAlertExpectFalse() {
        XCTAssertNotEqual(
            viewController.makeAnAlert(withTitle: "test", saying: "test"),
            UIAlertController(title: "test", message: "test_test", preferredStyle: UIAlertControllerStyle.alert)
        )
    }
}
