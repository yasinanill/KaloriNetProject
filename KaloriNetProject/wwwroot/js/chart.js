
var data = [
    { Responses: "Accepted", Share: 25 },
    { Responses: "Unresponded", Share: 26.5 },
    { Responses: "Rejected", Share: 25.4 }
]

// prepare chart data as an array
var source =
{
    datatype: "array",
    datafields: [
        { name: 'Responses' },
        { name: 'Share' }
    ],
    localdata: data
};

var dataAdapter = new $.jqx.dataAdapter(source, { async: false, autoBind: true, loadError: function (xhr, status, error) { alert('Error loading "' + source.url + '" : ' + error); } });

// prepare jqxChart settings
var settings = {
    title: "Geoff's Birthday Party",
    description: "",
    enableAnimations: true,
    showLegend: false,
    legendPosition: { left: 520, top: 140, width: 100, height: 100 },
    padding: { left: 5, top: 5, right: 5, bottom: 5 },
    titlePadding: { left: 0, top: 0, right: 0, bottom: 10 },
    source: dataAdapter,
    colorScheme: 'scheme13',
    seriesGroups:
        [
            {
                type: 'donut',
                showLabels: false,
                series:
                    [
                        {
                            dataField: 'Share',
                            displayText: 'Responses',
                            labelRadius: 100,
                            initialAngle: 15,
                            radius: 130,
                            innerRadius: 90,
                            centerOffset: 0,
                            formatSettings: { decimalPlaces: 1 },
                            color: '#00000'
                        }
                    ]
            }
        ]
};


