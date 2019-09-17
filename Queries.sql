/*for DataGridView*/
select [Bus].*, [Bus_Counter].time from [Bus] 
full outer join [Bus_Counter] on [Bus].[no] = [Bus_Counter].[bus_no]
/*for Search from DataGridView*/
select [Bus].*, [Bus_Counter].time from [Bus] 
full outer join [Bus_Counter] on [Bus].[no] = [Bus_Counter].[bus_no]
where Bus.no like "%or%" or bus.type like "a%" or Bus_Counter.time like "%s%"; 
/*For Search DataGridView*/
select *
from Bus
full outer join Bus_Counter
on [Bus].[no] = [Bus_Counter].[bus_no] 
where [Bus_Counter].[counter_name] = 'Magura-1'
and [Bus].[no] like '%36%' 
or [Bus].[type] = 1
or [Bus_Counter].[time] = '2019-09-02'
