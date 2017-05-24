var Order = require('../models/orderdata');
var async = require('async');


exports.index = function(req, res) {   
    
    async.parallel({
        order_count: function(callback) {
            Order.count(callback);            
        },
    }, function(err, results) {
    	console.log(results);
        res.render('index', {title: 'Serial Number Lookup', error: err, data: results});
    });
};

exports.post_handler = function(req, res) {
	var serial = req.body.name;
	res.redirect(order.url);
};

exports.order_detail = function(req, res, next) {

  async.parallel({
    order: function(callback) {     
      Order.findById(req.params.id)
        .exec(callback);
    },
  }, function(err, results) {
    if (err) { return next(err); }
    //Successful, so render
    res.render('order_detail', { title: 'Order Detail', order: results.order });
  });
    
};