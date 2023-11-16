Feature: ChangeTime

  Scenario: Change time link on the journey planner displays "Arriving" option
    Given the user is on the journey planner page
    When the user clicks on the "Change Time" link
    Then the "Arriving" option should be displayed
    And the user plans a journey based on arrival time
    Then the results should be displayed
