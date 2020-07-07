# DistanceCalculator

### Description
A REST service that calculates the distance between airports in miles by using their latitude and longitude.

### Local usage
You can run the service locally and test the API by requesting the following endpoint: `/api/distance/calculate`.

### Remote usage
The service has been deployed and can be requested here: 
`boyyoka-public.azurewebsites.net/api/distance/calculate`.

#### Request body
Your request body should look as follows: 

```json
{
	"pointA":"AMS",
	"pointB":"ALL"
}
```

pointA and pointB's values should both correspond to a valid 3 letter IATA airport code. 

#### Return value
The return value of this service is an integer that represents the distance in miles.
