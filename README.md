# Factory pattern on pricing strategy use case

### Business Case :
user story stated that : Every day I need to compare my product price against list of competitors. System should update my product price due to pricing strategy I defined. <br/>
#### Pricing strategy can be like below :
I need to set my price to be either (lower than , higher than , Match) My (average , minimum , maximum) competior by (amount , percenteage) [decimal value], but not lower than cost by (amount , percenteage) [decimal value] and not higher than cost by (amount , percenteage) [decimal value]. <br/>

![alt text](https://github.com/mfaddo/Factory-Design-Pattern-use-case/blob/master/image.png)

by reading above story we can find that there are too many options to decide how to update prices.<br/>
### Too complex ha ! 
to avoid writing all conditions on our Business Logic we need to define some contracts and implement them based on current situation and let Factory design pattern decide the right implementaion based on configuration.
### contracts :
- `ICompetitorAggregator` This interface define the contract for competitor aggregations.
- `ICalculateDestinationAmount` This interface define the contract for calculate the values. 

### Implementaions 
- For competitors aggregation , for each type we need to define an implementaion for that contract : 
  `CalculateAverageCompetitor` , `CalculateMaximumCompetitor` , `CalculateMinimumCompetitor`
- For DestinationAmount , we need tow implementations one for amuont and other for percentage : `CalculateDestinationByPercentage` , `CalculateDestinationByAmount`

### Factories 
Now to offload the implementation deceision , a factory will decide the implementaion based on configuration : 
- `FactorCompetitorAggregator` decide Aggregator implementaion
- `FactorAmountCalculations` decide Amount calculation implementaion 
- `FactorOperation` decide the Math operation to be applied (Add , Minus , Equal)

### Clean Business Logic 
Now you can find our busniss Logic Class `PricingStrategyApplier` is clean and perform all logic without a single-If

### Final Touches 
I created a sample tests `PricingStrategyApplierTests` that contains 4 test cases so you can test the implementation , mock calsses provided to simulate this operation.

