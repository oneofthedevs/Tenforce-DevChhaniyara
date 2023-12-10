# TenForce Hiring - Dev Chhaniyara

### Exercise 1: Calculate Average Moon Gravity
To achieve this, I took the approach to calculate the gravity of objects using the Gravitational Force. To find the gravity of the object in this manner, we need to know the mass and radius of the body and use the universal gravitational constant.

Gravitational force = (gravitational_constant * mass_of_object) / (radius)^2

If the required values are not available or is NULL, then that object is ignored while calculating the average. 

### Exercise 2: Alternate Solution
We can directly use the value of gravity for the moon provided by the API
##### Benefits:
1. Fewer calculations and computations on our end since we directly use the value provided
##### Drawbacks
1. Gravity data for many of the bodies (moons) provided by the API has a "0.0" value because the gravitational force of many of the smaller moons is negligible, due to this while calculating the average gravity for Saturn and Jupiter we get 0 which should not be the case
So to get a more precise answer, I opted for calculating the gravity rather than fetching from API.