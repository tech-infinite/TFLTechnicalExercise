Feature: EmptyLocation

  Scenario: Widget is unable to plan a journey if no locations are entered
    Given the user is on the journey planner page
    When no locations are entered into the widget
    #Then the user journey should not be planned
    
