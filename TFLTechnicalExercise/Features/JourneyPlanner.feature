Feature: JourneyPlanner

Scenario: Valid journey can be planned using the widget
    Given the user is on the journey planner page
    When valid locations are entered into the widget
    #And the user plans the journey
   # Then the results should be displayed

#Scenario: Widget is unable to provide results for an invalid journey
#    Given the user is on the journey planner page
#    When invalid locations are entered into the widget
#    And the user plans the journey
#    Then no results should be displayed
#
#  Scenario: Widget is unable to plan a journey if no locations are entered
#    Given the user is on the journey planner page
#    When no locations are entered into the widget
#    And the user plans the journey
#    Then no results should be displayed
#
#  Scenario: Change time link on the journey planner displays "Arriving" option
#    Given the user is on the journey planner page
#    When the user clicks on the "Change Time" link
#    Then the "Arriving" option should be displayed
#    And the user plans a journey based on arrival time
#    Then the results should be displayed
#
#  Scenario: Journey can be amended using the "Edit Journey" button
#    Given the user has planned a journey
#    When the user clicks on the "Edit Journey" button on the results page
#    And the user modifies the journey details
#    Then the updated results should be displayed
#
#  Scenario: "Recents" tab on the widget displays a list of recently planned journeys
#    Given the user is on the journey planner page
#    And all cookies are enabled
#    When the user plans a journey
#    And navigates to the "Recents" tab
#    Then a list of recently planned journeys should be displayed
