$(function () {
    function calendar(name) {
        var chk = $("#ctl00_MainContent_" + name).val();
        // alert(chk);
        var passname = "";
        if (chk == null) {
            passname = "#MainContent_" + name
        }
        else {

            passname = "#ctl00_MainContent_" + name
        }
        var d = new Date();
        var toDay = d.getDate() + '/'
    + (d.getMonth() + 1) + '/'
    + (d.getFullYear() + 543);
        $(passname).datepicker({
            dateFormat: 'dd/mm/yy',
            isBuddhist: true,
            defaultDate: toDay,
            dayNames: ['อาทิตย์', 'จันทร์', 'อังคาร',
                        'พุธ', 'พฤหัสบดี', 'ศุกร์', 'เสาร์'],
            dayNamesMin: ['อา.', 'จ.', 'อ.', 'พ.', 'พฤ.', 'ศ.', 'ส.'],
            monthNames: ['มกราคม', 'กุมภาพันธ์', 'มีนาคม',
                        'เมษายน', 'พฤษภาคม', 'มิถุนายน',
                        'กรกฎาคม', 'สิงหาคม', 'กันยายน',
                        'ตุลาคม', 'พฤศจิกายน', 'ธันวาคม'],
            monthNamesShort: ['ม.ค.', 'ก.พ.', 'มี.ค.', 'เม.ย.',
                         'พ.ค.', 'มิ.ย.', 'ก.ค.', 'ส.ค.', 'ก.ย.', 'ต.ค.',
                         'พ.ย.', 'ธ.ค.'],
            onSelect: function (dateText, inst) {
                dateBefore = $(this).val();
                var arrayDate = dateText.split("/");
                arrayDate[2] = parseInt(arrayDate[2]);
                $(this).val(arrayDate[0] + "/" + arrayDate[1] + "/" + arrayDate[2]);
            }
        });
    }
});