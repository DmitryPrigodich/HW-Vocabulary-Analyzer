Feature: Login

Scenario: Successful login
    Given user opens login page
    When user logs in with credentials from "Data/users.csv"
    Then user sees dashboard page