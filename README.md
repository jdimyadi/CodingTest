# CodingTest
Project for coding test

1. The project contains several files. UnitKind is enum with the units that our system supports. UnitPrefix is the prefixes that can be added to the UnitKind. For example bu adding 'centi' prefix to 'metre' unit kind, we get centimetre. 

2. BaseUnit class contains a UnitKind and UnitPrefix. If not Prefix is needed (for example to represent Metre, then UnitPrefix.Unity is used. Ignore Exponent value for now.

3. Measurement class contains a unit and a double measurement value. Task is to complete the ConvertTo() method in the method class so that it converts the value to the expected unit passed in as a parameter. 
