# Table Structure Dataset

This is the dataset of our ISSTA 2021 paper: **Semantic Table Structure Identification in Spreadsheets**. 

This dataset contains 50 spreadsheets and the corresponding table structure annotation information.

## Table Structure

The **table structure** describes the table header purposes and relationships of the tables. By inspecting the spreadsheet programming model and amounts of real-world spreadsheets, we summarize five header types and eight header relations as follows.

### 1. Header Type

In spreadsheet tables, headers are used to describe other cells and have different purposes. We divide headers into five types, i.e., value name, aggregation, index, index name and other, according to their purposes.

* **Value name**: A value name is the summary term of related data cells in the data region.
* **Index**: An index is a header for indexing data cells in the data region.
* **Index name**: An index name is a summary term to describe indexes in the header region.
* **Aggregation**: An aggregation indicates some values are calculated from other values.
* **Other**:  Some headers in the header regions are not used to describe other cells.

### 2. Header Relation

Given a header pair < h1,h2 >, we summarize eight relations between h1 and h2. Note that, in a header pair < h1, h2 >, we require that, h1 is located in the left of h2, otherwise, h1 is located on the top of h2. In this paper, we have this requirement for all header pairs.

* **h1 is the parent of h2**: Headers in a top or left header reagion can be organized into a hierarchy.

  Some index headers can form an **Index set**, in which all index headers are located in the same level in the hierarchy, and have the same parent if the parent exists.

* **h2 is the parent of h1**: Similar to the previous one.

* **h1 and h2 are siblings**: If h1 and h2 belong to the same index set, they are siblings.

* **h1 is the index name of h2**: If h1 is an index name, h2 is an index header, and h1 is used to describe h2, then h1 is the index name of h2.

* **h2 is the index name of h1**: Similar to the previous one.

* **h1 is the aggregation of h2’s index set**: h1 is an aggregation and h2 is a index header. If h1 is the aggregation of h2, then h1 is the aggregation of h2's index set.

* **h2 can be the aggregation of h1’s index set**: Similar to the previous one.

* **No relation of h1 and h2**: It means h1 and h2 do not have any of the above 7 relations.

## Subject

Folder `Subject` includes 50 spreadsheets from the internet.

## Annotation

We also provide the corresponding labeled table structures `annotation.txt` in Folder `Annotation` . According to our labeling rules, the labelers have labeled 54 table structures for the 50 spreadsheets.

Specifically for each table we will annotate the following structural information:

* #Table: Annotate the name of the spreadsheet file where the table is located (suffix can be omitted), the name of the workbook, the coordinates of the left topcorner of the table, and the coordinates of the right bottom corner of the table.
* #Class：Annotate the type of the table, where Class 1 indicates that the table structure is easy to understand.
* #Merged: Annotate all the merged cells in the table.
* #Top: If there are Indexes in the top header region of the table, annotate the hierarchical relationship between these Indexes.
* #Left: If there are Indexes in the left header region of the table, annotate the hierarchical relationship between these Indexes.
* #IndexSet: Annotate the Index sets of the table.
* #IndexName: Annotate the Index name of the corresponding Index set.
* #ValueName: Annotate the Value name that exists in the table in the corresponding position, and the same value name should be marked in the same row. Extract semantics for each Value Name as ID.
* #RowTotal: Annotate the "same-level" "Total" aggregation headers, which indicate the aggregated value of a row.
* #ColTotal: Annotate the "same level" "Total" aggregation headers, which indicate the aggregated value of a column.
* #CrossRowTotal: Annotate all the "cross-level" "Total" aggregation headers, which indicate the aggregated value of a row.
* #CrossColTotal:Annotate all the "cross-level" "Total" aggregation headers, which indicate the aggregated value of a column.
* #RowAggregated: Annotate all the "same-level" aggregation headers but not the "Total" headers (E.g., "Average"), which indicate the aggregated value of a row.
* #ColAggregated: Annotate all the "same-level" aggregation headers but not the "Total" headers(E.g., "Average"), which indicate the aggregated value of a column.
* #CrossRowAggregated: Annotate all the "cross-level" "Total" aggregation headers but not the "Total" headers (E.g., "Average"), which indicate the aggregated value of a row.
* #CrossColAggregated:Annotate all the "cross-level" "Total" aggregation headers but not the "Total" headers (E.g., "Average"), which indicate the aggregated value of a column.

The above feature information reflects the five header types and eight  header relationships we have defined.

## Related Paper

Folder `Research Paper` includes the related paper to the dataset.

Yakun Zhang, Xiao Lv, Haoyu Dong, Wensheng Dou, Shi Han, Dongmei Zhang, Jun Wei, and Dan Ye. 2021. **Semantic Table Structure Identification in Spreadsheets**. In Proceedings of the 30th ACM SIGSOFT International Symposium on Software Testing and Analysis (ISSTA ’21), July 11–17, 2021, Virtual, Denmark. ACM, New York, NY, USA, 13 pages.

If you use this dataset, please cite this paper.

