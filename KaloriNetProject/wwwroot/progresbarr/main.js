(function($){
    'use strict';   

   jQuery(document).ready(function($){
    
 
    // skill circle progress bar
    var skillLevel1 = $('.skill-item .first').data('skill-level');
    var skillLevel2 = $('.skill-item .second').data('skill-level');
    var skillLevel3 = $('.skill-item .third').data('skill-level');
    var skillLevel4 = $('.skill-item .fourth').data('skill-level');
    //first.circle
    $('.first.circle').circleProgress({
      value: '0.' + skillLevel1,
      size: 200,
      emptyFill: "#f2f2f2",
      fill: {
        color: "#39b54a"
      }
    }).on('circle-animation-progress', function(event, progress) {
        $(this).find('h2').html(Math.round(skillLevel1 * progress) + '<span>%</span>');
    });

    //second.circle
    $('.second.circle').circleProgress({
      value: '0.' + skillLevel2,
      size: 110,
      emptyFill: "#f2f2f2",
      fill: {
        color: "#f26522"
      }
    }).on('circle-animation-progress', function(event, progress) {
      $(this).find('h2').html(Math.round(skillLevel2 * progress) + '<i>%</i>');
    });

    //third.circle
    $('.third.circle').circleProgress({
      value: '0.' + skillLevel3,
      size: 110,
      emptyFill: "#f2f2f2",
      fill: {
        color: "#6e41ff"
      }
    }).on('circle-animation-progress', function(event, progress) {
        $(this).find('h2').html(Math.round(skillLevel3 * progress) + '<span>%</span>');
    });

    //fourth.circle
    $('.fourth.circle').circleProgress({
      value: '0.' + skillLevel4,
      size: 110,
      emptyFill: "#f2f2f2",
      fill: {
        color: "#ec008c"
      }
    }).on('circle-animation-progress', function(event, progress) {
        $(this).find('h2').html(Math.round(skillLevel4 * progress) + '<span>%</span>');
    });

   });
  
})(jQuery);	 