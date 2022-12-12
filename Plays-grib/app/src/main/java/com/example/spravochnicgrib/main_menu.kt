package com.example.spravochnicgrib

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.Menu
import android.view.MenuItem
import android.view.View

class main_menu : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        setTheme(R.style.Theme_SpravochnicGrib)
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main_menu)
    }
    override fun onCreateOptionsMenu(menu: Menu?): Boolean {
        super.onCreateOptionsMenu(menu)
        menuInflater.inflate(R.menu.menu, menu)
        return true
    }
    override fun onOptionsItemSelected(item: MenuItem): Boolean{
        when(item.itemId) {
            R.id.o_program -> {
                val intent = Intent(this@main_menu, docuventation::class.java)
                intent.addFlags(
                    Intent.FLAG_ACTIVITY_CLEAR_TOP or
                            Intent.FLAG_ACTIVITY_SINGLE_TOP)
                startActivity(intent)
            }
        }
        return super.onOptionsItemSelected(item)
    }

    fun aidovito(view: View) {
        val intent: Intent = Intent(this@main_menu,aidov_grib::class.java)
        startActivity(intent)
    }

    fun kat_1(view: View) {
        val intent: Intent = Intent(this@main_menu,vkus_1::class.java)
        startActivity(intent)
    }

    fun kat_3(view: View) {
        val intent: Intent = Intent(this@main_menu,vkus3::class.java)
        startActivity(intent)
    }

    fun falses(view: View) {
        val intent: Intent = Intent(this@main_menu,lojnie_grib::class.java)
        startActivity(intent)
    }

    fun ogorod(view: View) {
        val intent: Intent = Intent(this@main_menu,ogorod::class.java)
        startActivity(intent)
    }

    fun no_sedob(view: View) {
        val intent: Intent = Intent(this@main_menu,not_edible::class.java)
        startActivity(intent)
    }

    fun kat_2(view: View) {
        val intent: Intent = Intent(this@main_menu,vkus2::class.java)
        startActivity(intent)
    }
}