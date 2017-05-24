var mongoose = require('mongoose');

var Schema = mongoose.Schema;

var OrderSchema = Schema(
{
	_id: Schema.Types.ObjectId,
	SerialNumber_ID: {type: String, required: true},
	CustomerID: {type: String, required: true},
	OrderDate: {type: Date},
	OrderNumber: {type: String},
	SiteName: {type: String},
	Description: {type: String},
	TypeURL: {type: String}
});

OrderSchema
 .virtual('url')
 .get(function () {
 	return '/order/' + this.SerialNumber_ID;
 });

 module.exports = mongoose.model('OrderData', OrderSchema);


// {
//     "_id": {
//         "$oid": "5925d54a05bb9d8ef17aefb0"
//     },
//     "SerialNumber_ID": "AL14893",
//     "CustomerID": "beejes",
//     "OrderDate": "2017-04-06 23:04:00",
//     "OrderNumber": "20170406-0000031",
//     "SiteName": "Official Website",
//     "Description": "Allen Head White",
//     "TypeURL": ""
// }