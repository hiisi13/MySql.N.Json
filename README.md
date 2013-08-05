MySql.N.Json
============

Super simple tool that allows to export MySql table content to json file

### Usage

Export entire table

mysqlnjson -s #{mysql server} -d #{database} -u #{user id} -p #{password} -t #{table name} > #{output file name}

###### or

Run some specific query

mysqlnjson -s #{mysql server} -d #{database} -u #{user id} -p #{password} -e #{ select * from whatever table where ... } > #{output file name}


