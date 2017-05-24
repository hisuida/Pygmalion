var express = require('express');
var router = express.Router();

var order_controller = require('../controllers/orderController');

router.get('/', order_controller.index);
router.post('/', order_controller.post_handler);
router.get('/order/:id', order_controller.order_detail);

module.exports = router;