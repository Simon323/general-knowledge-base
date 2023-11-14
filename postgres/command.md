
## Table of Contents
- [Table of Contents](#table-of-contents)
- [Row to JSON](#row-to-json)
- [Select result as single json object](#select-result-as-single-json-object)
- [Select result as array of json objects](#select-result-as-array-of-json-objects)

## Row to JSON
```sql
SELECT ROW_TO_JSON(ROW('e30b930d-9093-4084-ae3d-dee179cf82e7', 170840, true, 10, 'modus.mp4',	1));	
```

## Select result as single json object
```sql
SELECT to_json(t) FROM your_table AS t --where condition;
```

## Select result as array of json objects
```sql
SELECT json_agg(t) FROM your_table AS t --where condition;
```
OR
```sql
SELECT json_agg(row_to_json(t)) FROM your_table AS t --WHERE condition;
```