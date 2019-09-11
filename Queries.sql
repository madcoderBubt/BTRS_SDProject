/*for DataGridView*/
select [Bus].*, [Bus_Counter].time from [Bus] 
full outer join [Bus_Counter] on [Bus].[no] = [Bus_Counter].[bus_no]
/*for Search from DataGridView*/
select [Bus].*, [Bus_Counter].time from [Bus] 
full outer join [Bus_Counter] on [Bus].[no] = [Bus_Counter].[bus_no]
where Bus.no like "%or%" or bus.type like "a%" or Bus_Counter.time like "%s%"; 