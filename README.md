# sidecars.services.facedetection.DAPR
This repo is for exploring the capabilities of DAPR (Distributed Application Run Time). We would be using the scenario of Face Detection, in which we would have an Order Microservice, Face Detection Microservice (Powered by Azure Face API), MVC Front End Application, Email Notification Service. All these services would be powered by dapr's Side Cars. All the communication between the microservices would be handled by the sidecars using messaging queues.

## Service Invocation Block:
This block showcase the ability of services communicating by service invocation mechanism. WeatherApp SideCar communicates with WeatherApi SideCar.
