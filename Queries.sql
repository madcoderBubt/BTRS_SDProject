/*for DataGridView*/
select [Bus].*, [Bus_Counter].time from [Bus] 
full outer join [Bus_Counter] on [Bus].[no] = [Bus_Counter].[bus_no]
/*For Search DataGridView*/
select *
from [Bus]
where [Bus].[no] =
any (
	select [Bus_Counter].[bus_no]
	from [Bus_Counter]
	where counter_name = 'Magura-1'
)
--Advanced search in Database to find expected list of buses
select * 
from [Bus]
full outer join [Bus_Counter]
on [Bus].[no] = [Bus_Counter].[bus_no]
where [Bus_Counter].[counter_name] = 'Magura-1'
and [Bus].[type] = 5 
and [Bus_Counter].[date] = '1-Sep-19'
and [Bus_Counter].[bus_no] = 
any(
	select [Bus_Counter].[bus_no]
	from [Bus_Counter]
	where counter_name like 'Dhaka%'
)