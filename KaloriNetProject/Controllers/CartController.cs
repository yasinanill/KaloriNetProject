using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using KaloriNetProject.BusinessLayer.Abstract;
using KaloriNetProject.Identity;
using KaloriNetProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaloriNetProject.Controllers
{ 
    
    [Authorize]
    public class CartController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private ICartService _cartService;
        private IRecordService _recordService;

        public CartController(ICartService cartService, IRecordService recordService, UserManager<ApplicationUser> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
            _recordService = recordService;
        }
        public IActionResult Index()
        {

            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));
            return View(new CartModel()
            {
                CartID = cart.ID,
                CartItem = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemID = i.ID,
                    ProductID = i.Product.ID,
                    Name = i.Product.Name,
                    Calorie = ((int)i.Product.Calorie),
                    imageUrl = i.Product.Image,
                    Fat=i.Product.Fat,
                    Carbo= i.Product.carbo,
                    Protein= i.Product.
                    Protein = i.Product.Protein, 
                    Quantity = i.Quantity,
                    amount = i.Product.amount,
                   
                   
                    
                }).ToList()
            });
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            _cartService.AddToCart(_userManager.GetUserId(User), productId, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteFromCart(int productId)
        {
            _cartService.DeleteFromCart(_userManager.GetUserId(User), productId);
            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));

            var recordModel = new DailyRecordModel();

            recordModel.CartModel = new CartModel()
            {
                CartID = cart.ID,
                CartItem = cart.CartItems.Select(i => new CartItemModel()
                {
                    CartItemID = i.ID ,
                    ProductID = i.Product.ID,
                    Name = i.Product.Name,
                    Calorie = ((int)i.Product.Calorie),
                       Quantity = i.Quantity
                }).ToList()
            };

            return View(recordModel);
        }
        [HttpPost]
        public IActionResult Checkout(DailyRecordModel model)
        {
            if (ModelState.IsValid)
            {
                var userId = _userManager.GetUserId(User);
                var cart = _cartService.GetCartByUserId(userId);

                model.CartModel = new CartModel()
                {
                    CartID = cart.ID,
                    CartItem = cart.CartItems.Select(i => new CartItemModel()
                    {
                        CartItemID = i.ID,
                        ProductID = i.Product.ID,
                        Name = i.Product.Name,
                        Calorie = ((int)i.Product.Calorie),
                       Quantity = i.Quantity
                    }).ToList()
                };
                if (ModelState.IsValid)
                {
                    SaveOrder(model, userId);
                    ClearCart(cart.ID.ToString());
                    return RedirectToAction("Index");
                }
            }
               
            return View(model);
        }
        private void SaveOrder(DailyRecordModel model,  string userId)
        {
            var order = new DailyRecord();

            order.RecordNumber = new Random().Next(111111, 999999).ToString();
           
            order.recordDate = DateTime.Now;
            order.RecordNote = model.RecordNote;
            order.RecordNote2 = model.RecordNote2;

            order.UserId = userId;

            foreach (var item in model.CartModel.CartItem)
            {
                var orderitem = new DailyRecordItem()
                {
                    Calorie = item.Calorie,
                    Quantity = item.Quantity,
                    ProductId = item.ProductID
                };
                order.DailyRecordItem.Add(orderitem);
            }
            _recordService.Create(order);
        }
        private void ClearCart(string cartId)
        {
            _cartService.ClearCart(cartId);
        }
        public IActionResult GetRecords()
        {
            var records = _recordService.GetOrders(_userManager.GetUserId(User));
            var dailyRecordModels = new List<RecordListModel>();
            RecordListModel recordModel;

            foreach (var order in records)
            {
                recordModel = new RecordListModel();
                recordModel.recordId = order.Id;
                recordModel.recordNote = order.RecordNote;
                recordModel.recordNote2 = order.RecordNote2;
                recordModel.recordDate = order.recordDate;
                recordModel.recordNumber = order.RecordNumber;


                recordModel.RecordItems = order.DailyRecordItem.Select(i => new RecordItemModel()
                {
                    RecordItemId = i.Id,
                    Name = i.Product.Name,
                    Calorie = i.Calorie,
                    Quantity = i.Quantity,
                    
                    
                }).ToList();

                dailyRecordModels.Add(recordModel);
            
            }
            
            return View(dailyRecordModels);
            
        }
            
    }
}
