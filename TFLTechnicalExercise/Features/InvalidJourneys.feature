Feature: InvalidJourneys

Scenario: Widget is unable to provide results for an invalid journey
    Given the user is on the journey planner page
    When invalid locations are entered into the widget
    And the user plans the journey
    Then no results should be displayed