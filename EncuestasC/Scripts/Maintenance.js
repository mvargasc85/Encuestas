function createCodPresGrid(divId, items) {
    $("#" + divId).kendoGrid({
        dataSource: {
            data: items,
            schema: {
                model: {
                    fields: {
                        Id: { type: "number" },
                        Codigo: { type: "number" }
                    }
                }
            },
            pageSize: 5
        },
        //        height: 100,
        scrollable: false,
        sortable: true,
        filterable: true,
        columns: [
            { field: "Id", title: "Id", width: "50px" },
            { field: "Codigo", title: "Codigo", width: "50px"}]
    });
}