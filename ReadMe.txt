Differences between ViewBag, ViewData, and TempData
	ViewBag: data from controller to view, dynamic type, does not require type casting
	ViewData: data from controller to view, dictionary, requires type casting
	TempData: dictionary, life cycle is one page to another, same HTTP request, controller to controller, action to action, redirect